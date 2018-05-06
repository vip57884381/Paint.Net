/////////////////////////////////////////////////////////////////////////////////
// Paint.NET                                                                   //
// Copyright (C) Rick Brewster, Tom Jackson, and past contributors.            //
// Portions Copyright (C) Microsoft Corporation. All Rights Reserved.          //
// See src/Resources/Files/License.txt for full licensing and attribution      //
// details.                                                                    //
// .                                                                           //
/////////////////////////////////////////////////////////////////////////////////

using PaintDotNet.HistoryFunctions;
using PaintDotNet.HistoryMementos;
using System;

namespace PaintDotNet.Actions
{
    public sealed class CutAction
    {
        public static string StaticName
        {
            get
            {
                return PdnResources.GetString("CutAction.Name");
            }
        }

        public static ImageResource StaticImage
        {
            get
            {
                return ImageResource.Get("Icons.MenuEditCutIcon.png");
            }
        }

        public void PerformAction(DocumentWorkspace documentWorkspace)
        {
            HistoryMemento finalHM;

            if (documentWorkspace.Selection.IsEmpty)
            {
                finalHM = null;
            }
            else
            {
                CopyToClipboardAction ctca = new CopyToClipboardAction(documentWorkspace);
                bool result = ctca.PerformAction();

                if (!result)
                {
                    finalHM = null;
                }
                else
                {
                    using (new PushNullToolMode(documentWorkspace))
                    {
                        EraseSelectionFunction esa = new EraseSelectionFunction();
                        HistoryMemento hm = esa.Execute(documentWorkspace);

                        CompoundHistoryMemento chm = new CompoundHistoryMemento(
                            StaticName,
                            StaticImage,
                            new HistoryMemento[] { hm });

                        finalHM = chm;
                    }
                }
            }

            if (finalHM != null)
            {
                documentWorkspace.History.PushNewMemento(finalHM);
            }
        }

        public CutAction()
        {
        }
    }
}
