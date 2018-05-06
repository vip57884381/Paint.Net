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
    public class ReadyToInstallState
        : UpdatesState,
          INewVersionInfo
    {
        private PdnVersionInfo newVersionInfo;
        private string installerPath;

        public PdnVersionInfo NewVersionInfo
        {
            get
            {
                return this.newVersionInfo;
            }
        }

        public override void OnEnteredState()
        {
        }

        public override void ProcessInput(object input, out State newState)
        {
            if (input.Equals(UpdatesAction.Continue))
            {
                newState = new InstallingState(this.installerPath);
            }
            else if (input.Equals(UpdatesAction.Cancel))
            {
                newState = new DoneState();
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public ReadyToInstallState(string installerPath, PdnVersionInfo newVersionInfo)
            : base(false, true, MarqueeStyle.None)
        {
            this.installerPath = installerPath;
            this.newVersionInfo = newVersionInfo;
        }
    }
}
