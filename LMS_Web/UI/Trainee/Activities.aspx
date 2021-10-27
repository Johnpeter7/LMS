<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Activities.aspx.cs"  MasterPageFile="../../Master_Template/Trainee/TraineeGroupDashBoard.Master" Inherits="LMS_Web.UI.Trainee.Activities" %>
<%@ Register Src="~/UserControls/HeaderContent.ascx" TagPrefix="uc1" TagName="HeaderContent" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentTraineeGroups" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
 <link href="../../css/Panel.css" rel="stylesheet">
<style>
.grid-container {
  display: grid;
  grid-column-gap: 50px;
  grid-template-columns: auto auto auto;
  
  padding: 10px;
}

.grid-item {
  background-color: rgba(255, 255, 255, 0.8);
  border: 1px solid rgba(0, 0, 0, 0.8);
  padding: 20px;
  font-size: 30px;
  text-align: center;
}
    </style>
    <uc1:HeaderContent runat="server" ID="HeaderContent" />
    <div class="grid-container">
        <%=getAssesmentResult()%>
     
     </div>
     
</asp:Content>

