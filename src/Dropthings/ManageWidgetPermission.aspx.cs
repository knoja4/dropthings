#region Header

// Copyright (c) Omar AL Zabir. All rights reserved.
// For continued development and updates, visit http://msmvps.com/omar

#endregion Header

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Workflow.Runtime;

using Dropthings.Business;
using Dropthings.Business.Container;
using Dropthings.Business.Workflows;
using Dropthings.Business.Workflows.UserAccountWorkflow;
using Dropthings.Business.Workflows.UserAccountWorkflows;
using Dropthings.DataAccess;
using Dropthings.Web.Util;

public partial class ManageWidgetPermissionPage : System.Web.UI.Page
{
    #region Properties

    protected string[] Roles
    {
        get
        {
            return System.Web.Security.Roles.GetAllRoles();
        }
    }

    protected List<Widget> Widgets
    {
        get;
        set;
    }

    #endregion Properties

    #region Methods

    public static void ShowMessage(Label label, string message, bool isError)
    {
        label.ForeColor = System.Drawing.Color.DodgerBlue;
        label.Text = message;

        if (isError)
        {
            label.ForeColor = System.Drawing.Color.Red;
            label.Font.Bold = true;
        }
    }

    protected bool IsWidgetInRole(int widgetId, string roleName)
    {
        return new DashboardFacade(Profile.UserName).IsWidgetInRole(widgetId, roleName);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Widgets = new DashboardFacade(Profile.UserName).GetWidgetList(Enumerations.WidgetTypeEnum.PersonalPage);
        }
    }

    #endregion Methods
}