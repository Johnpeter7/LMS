<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainer/ManageGroupDashBoard.Master" AutoEventWireup="true" CodeBehind="AddTrainee.aspx.cs" Inherits="LMS_Web.UI.Trainer.AddTrainee" %>

<%@ Register Src="~/UserControls/HeaderContent.ascx" TagPrefix="uc1" TagName="HeaderContent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentManageGroup" runat="server">
        <style>
        .TextBoxDesign{
    width:70%;
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
    </style>
    <uc1:HeaderContent runat="server" ID="HeaderContent" />
    <div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-red ">
         <h5>Enroll the Trainee..</h5>
   <table>
       <tr>
           <td>
               <label>First Name</label>
               <asp:TextBox ID="txtFirstName" runat="server" CssClass="TextBoxDesign"></asp:TextBox>
               <br />
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter First Name"  ControlToValidate="txtFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
           </td>
           <td>
               <label>Last Name</label>
               <asp:TextBox ID="txtLastName" runat="server" CssClass="TextBoxDesign"></asp:TextBox>
               <br />
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Enter Last Name" ControlToValidate="txtLastName" ForeColor="Red"></asp:RequiredFieldValidator>
           </td>
          
           
       </tr>
       <tr>
           
           <td>
               <label>Email</label>
               <asp:TextBox ID="txtEmail" runat="server" CssClass="TextBoxDesign" ></asp:TextBox>
               <br />
               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Enter E-mail Id" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*Invalid E-mail" ControlToValidate="txtEmail" ForeColor="red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
           </td>
             <td>
               <label>Mobile_No</label>
               <asp:TextBox ID="txtMobile_No" runat="server" CssClass="TextBoxDesign" ></asp:TextBox>
               <br />
               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Enter Mobile No" ControlToValidate="txtMobile_No" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"  ErrorMessage="*Invalid Mobile No" ControlToValidate="txtMobile_No" ForeColor="Red" ValidationExpression="^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[789]\d{9}$"></asp:RegularExpressionValidator>
             </td>
       
       </tr>
       <tr>
            <td>
               <label>DOB</label>
               <asp:TextBox ID="txtDOB" runat="server" CssClass="TextBoxDesign" TextMode="Date" ></asp:TextBox>
               <br />
               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Enter DOB" ControlToValidate="txtDOB" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
                <asp:RangeValidator ID="RangeValidator1" type="Date" runat="server" minimumvalue="01-01-1999" maximumvalue="01-01-2002" ErrorMessage="*Invalid Date" ControlToValidate="txtDOB" ForeColor="Red"></asp:RangeValidator>
            </td>
           <td>
               <asp:Button ID="btnSave" runat="server" Text="Save Details" CssClass="ButtonDesign" OnClick="btnSave_Click"/>
           </td>
       </tr>
      <tr>
          <asp:Label ID="lblMessage" runat="server" Text="" Visible="false"></asp:Label>
      </tr>
       
   </table>
    
</div>
         
   
</asp:Content>



