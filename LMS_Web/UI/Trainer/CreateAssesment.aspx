<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainer/ManageGroupDashBoard.Master" AutoEventWireup="true" CodeBehind="CreateAssesment.aspx.cs" Inherits="LMS_Web.UI.Staff.CreateAssesment" %>

<%@ Register Src="~/Master_Template/Trainer/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>
<%@ Register Src="~/UserControls/HeaderContent.ascx" TagPrefix="uc1" TagName="HeaderContent" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentManageGroup" runat="server">
    
    <uc1:HeaderContent runat="server" ID="HeaderContent" />
    <div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-red ">
       
        <uc1:WebUserControl1 runat="server" id="WebUserControl1" />
    </div>
 </asp:Content>


