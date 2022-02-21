using EnvDTE;
using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace CodeSiteMT
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(GuidList.guidCodeSiteMTPkgString)]
    public sealed class CodeSiteMTPackage : Package
    {
        protected override void Initialize()
        {
            base.Initialize();
            if (GetService(typeof(IMenuCommandService)) is OleMenuCommandService mcs)
            {
                CommandID menuCommandID = new CommandID(GuidList.guidCodeSiteMTCmdSet, (int)PkgCmdIDList.cmdidCodeSiteMT);
                mcs.AddCommand(new MenuCommand(MenuItemCallback, menuCommandID));
            }
        }

        private void MenuItemCallback(object sender, EventArgs e)
        {
            DTE dte = (DTE)GetService(typeof(DTE));
            MethodTracerForm.Execute(dte);
        }
    }
}
