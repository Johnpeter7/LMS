<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainee/TraineeDashBoard.Master" AutoEventWireup="true" CodeBehind="TraineeDashBoard.aspx.cs" Inherits="LMS_Web.UI.Trainee.TraineeDashBoard" %>
<%@ Register Src="~/UserControls/TraineeGroupViewList.ascx" TagPrefix="uc1" TagName="TraineeGroupViewList" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="TraineeMainDashBoardContent" runat="server">
    
      <uc1:TraineeGroupViewList runat="server" ID="TraineeGroupViewList1" />
 </asp:Content>



