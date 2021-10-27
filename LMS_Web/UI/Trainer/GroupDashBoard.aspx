

<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainer/ManageGroupDashBoard.Master" AutoEventWireup="true" CodeBehind="GroupDashBoard.aspx.cs" Inherits="LMS_Web.UI.Staff.StaffCreateGroup" %>

<%@ Register Src="~/UserControls/HeaderContent.ascx" TagPrefix="uc1" TagName="HeaderContent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentManageGroup" runat="server">
    <style>
        .TextBoxDesign{
    width:86%;
    padding:12px 40px;
    margin:10px 0;
    box-sizing:border-box;
    border:none;
    border-bottom:1px solid black;
    text-align:left;

}
        .ButtonDesign{
background-color:  #ff6666;
  border: none;
  color: black;
  padding: 10px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  cursor: pointer;
  border-radius: 5px;
} 
    </style>
     <%-- <div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-blue">
          
             <h4><asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></h4>
          <p><asp:Label ID="lblDescripton" runat="server" Text=""></asp:Label></p>
          <p>Created on :<asp:Label ID="lblDate" runat="server" Text=""></asp:Label></p>
             </div>--%>
    <uc1:HeaderContent runat="server" id="HeaderContent" />

</asp:Content>