namespace CountsUpdate_win_service
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountUpdate_Win_Service = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller_CountUpdate_Win_Service = new System.ServiceProcess.ServiceInstaller();
            // 
            // CountUpdate_Win_Service
            // 
            this.CountUpdate_Win_Service.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.CountUpdate_Win_Service.Password = null;
            this.CountUpdate_Win_Service.Username = null;
            this.CountUpdate_Win_Service.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstallerCountUpdate_Win_Service);
            // 
            // serviceInstaller_CountUpdate_Win_Service
            // 
            this.serviceInstaller_CountUpdate_Win_Service.DisplayName = "CountUpdate_Win_Service";
            this.serviceInstaller_CountUpdate_Win_Service.ServiceName = "CountUpdate_Win_Service";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.CountUpdate_Win_Service,
            this.serviceInstaller_CountUpdate_Win_Service});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller CountUpdate_Win_Service;
        private System.ServiceProcess.ServiceInstaller serviceInstaller_CountUpdate_Win_Service;
    }
}