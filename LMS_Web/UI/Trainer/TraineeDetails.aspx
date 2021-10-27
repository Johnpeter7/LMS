<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TraineeDetails.aspx.cs" MasterPageFile="~/Master_Template/Trainer/MainDashBoard.Master" Inherits="LMS_Web.UI.Trainer.TraineeDetails" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainDashBoardContent" runat="server">
<style>
.mydatagrid
{
width: 100%;
border-radius:8px;
border: solid 1px black;
min-width: 80%;
}
.header
{
background-color: #f2f2f2;
font-family: Arial;
color: #000;
border: none 0px transparent;
height: 25px;
text-align: center;
font-size: 16px;
}



.rows
{
background-color: #fff;
font-family: Arial;
font-size: 14px;
color: #000;
min-height: 25px;
text-align: left;
border: none 0px transparent;
}
.rows:hover
{
background-color: #00e6e6;
font-family: Arial;
color: #fff;
text-align: left;
}
.selectedrow
{
background-color: #00e6e6;
font-family: Arial;
color: #fff;
font-weight: bold;
text-align: left;
}
.mydatagrid a /** FOR THE PAGING ICONS **/
{



padding: 5px 5px 5px 5px;
color: #000;
text-decoration: none;
font-weight: bold;
}



.mydatagrid a:hover /** FOR THE PAGING ICONS HOVER STYLES**/
{
background-color: #000;
color: #fff;
}
.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
{
background-color: #fff;
color: #000;
padding: 5px 5px 5px 5px;
}
.pager
{
background-color: #fff;
font-family: Arial;
color: White;
height: 30px;
text-align: left;
}



.mydatagrid td
{
padding: 5px;
}
.mydatagrid th
{
padding: 5px;
}
</style>
<div class="w3-panel w3-card-4">
<h4>TraineeDetails...</h4>
<asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" OnPageIndexChanging="GridDetails_PageIndexChanging" >



</asp:GridView>



<%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>--%>



</div>
</asp:Content>