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
    public class ReadyToCheckState
        : UpdatesState
    {
        public override void OnEnteredState()
        {
        }

        public override void ProcessInput(object input, out State newState)
        {
            if (input.Equals(UpdatesAction.Continue))
            {
                newState = new CheckingState();
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public ReadyToCheckState()
            : base(false, true, MarqueeStyle.None)
        {
        }
    }
}
