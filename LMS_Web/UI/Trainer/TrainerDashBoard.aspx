
<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainer/MainDashBoard.Master" AutoEventWireup="true" CodeBehind="TrainerDashBoard.aspx.cs" Inherits="LMS_Web.UI.Staff.StaffDashBoard"  %>
<%@ Register Src="~/UserControls/GroupListView.ascx" TagPrefix="uc1" TagName="GroupListView" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainDashBoardContent" runat="server">
<uc1:GroupListView runat="server" id="GroupListView" />
</asp:Content>




