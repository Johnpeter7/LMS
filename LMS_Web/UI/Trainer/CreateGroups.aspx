
<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainer/MainDashBoard.Master" AutoEventWireup="true" CodeBehind="CreateGroups.aspx.cs"Inherits="LMS_Web.UI.Trainer.CreateGroups" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainDashBoardContent" runat="server">
 <style>
.TextBoxDesign{
   width:86%;
    padding:12px 40px;
    margin:10px 0;
    box-sizing:border-box;
    border:none;
    border-bottom:1px solid black;
    

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
 <div class="w3-panel w3-round w3-card ">
     <h4>Group Creation..</h4>
     <table>
         <tr>
             <td>Title</td>
             <td>
                 <asp:TextBox ID="txtTitle" runat="server" CssClass="TextBoxDesign"></asp:TextBox>
                 <br />
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter Title" ControlToValidate="txtTitle" ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
          
         
         </tr>
         <tr>
             <td>Description</td>
              <td>
              <asp:TextBox ID="txtDesc" runat="server" CssClass="TextBoxDesign"  ></asp:TextBox>
              <br />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Enter Description" ControlToValidate="txtDesc" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
         </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Create" CssClass="ButtonDesign2" OnClick="Button1_Click" />
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
            </td>
        </tr>
     </table>
   </div>

</asp:Content>


