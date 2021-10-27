
<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainee/TraineeGroupDashBoard.Master" AutoEventWireup="true" CodeBehind="ReadingMaterialsData.aspx.cs" Inherits="LMS_Web.UI.Trainee.ReadingMaterialsData" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentTraineeGroups" runat="server">
<link rel="stylesheet" href="https://ww.w3schools.com/w3css/4/w3.css">
<link href="../../css/Panel.css" rel="stylesheet">
<%=getGroupData()%>

</asp:Content>

