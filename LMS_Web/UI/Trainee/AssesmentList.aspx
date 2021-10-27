<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="../../Master_Template/Trainee/TraineeGroupDashBoard.Master"  CodeBehind="AssesmentList.aspx.cs" Inherits="LMS_Web.UI.Trainee.AssesmentList" %>

<%@ Register Src="~/UserControls/HeaderContent.ascx" TagPrefix="uc1" TagName="HeaderContent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentTraineeGroups" runat="server">
    <link rel="stylesheet" href="https://ww.w3schools.com/w3css/4/w3.css">
 <link href="../../css/Panel.css" rel="stylesheet">
    <uc1:HeaderContent runat="server" ID="HeaderContent" />
    <%=getAssesmentList()%>
</asp:Content>

