
<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainer/ManageGroupDashBoard.Master" AutoEventWireup="true" CodeBehind="TrainerUploadFile.aspx.cs"Inherits="LMS_Web.UI.Staff.StaffUploadFile" %>

<%@ Register Src="~/UserControls/HeaderContent.ascx" TagPrefix="uc1" TagName="HeaderContent" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentManageGroup" runat="server">

   <style>
        .TextBoxDesign{
   width:100%;
    padding:12px 40px;
    margin:10px 0;
    box-sizing:border-box;
    border:none;
    border-bottom:1px solid black;
    

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
        .ButtonDesign2{
background-color:  #00e6e6;
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
    <uc1:HeaderContent runat="server" ID="HeaderContent" />
    <div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-red ">
        <h4>Upload File...</h4>
        <table>
            <tr>
                <td>
                    <asp:TextBox ID="txtFileName" runat="server" CssClass="TextBoxDesign" PlaceHolder="FileName"></asp:TextBox></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="TextBoxDesign">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>Image</asp:ListItem>
                        <asp:ListItem>Video</asp:ListItem>
                        <asp:ListItem>PDF</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server"  CssClass="ButtonDesign2" AllowMultiple="True"/></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Upload" runat="server" Text="Button" CssClass="ButtonDesign" OnClick="Upload_Click" /></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>


