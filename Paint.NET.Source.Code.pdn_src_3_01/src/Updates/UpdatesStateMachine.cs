/////////////////////////////////////////////////////////////////////////////////
// Paint.NET                                                                   //
// Copyright (C) Rick Brewster, Tom Jackson, and past contributors.            //
// Portions Copyright (C) Microsoft Corporation. All Rights Reserved.          //
// See src/Resources/Files/License.txt for full licensing and attribution      //
// details.                                                                    //
// .                                                                           //
/////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace PaintDotNet.Updates
{
    public class UpdatesStateMachine
        : StateMachine
    {
        private Control uiContext;
        public Control UIContext
        {
            get
            {
                return this.uiContext;
            }

            set
            {
                this.uiContext = value;
            }
        }

        public UpdatesStateMachine()
            : base(new StartupState(), new object[] { UpdatesAction.Continue, UpdatesAction.Cancel })
        {
        }
    }
}
