
<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainee/TraineeDashBoard.Master" AutoEventWireup="true" CodeBehind="TraineeProfile.aspx.cs"  Inherits="LMS_Web.UI.Trainee.TraineeProfile" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="TraineeMainDashBoardContent" runat="server">
        <link href="../../css/Controls.css" rel="stylesheet">
    <asp:Panel ID="Panel1" runat="server" >
<div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-red ">
    <table >
        <tr>
            <td class="LabelDesign2">FirstName</td>

            <td>
                :<asp:Label ID="lblFirstName" runat="server" Text="" CssClass="LabelDesign"></asp:Label>
               
            <td class="LabelDesign2">LastName</td>
            <td>
                :<asp:Label ID="lblLastName" runat="server" Text="" CssClass="LabelDesign"/>
                
            </td>
        </tr>
        <tr>
            <td class="LabelDesign2">Email</td>
            <td>
                :<asp:Label ID="lblEmail" runat="server" Text="" CssClass="LabelDesign"/>
              

            </td>
            <td class="LabelDesign2">Password</td>
            <td>
                :<asp:Label ID="lblPassword" runat="server" Text="" CssClass="LabelDesign"/>
                

            </td>
        </tr>
        <tr>
            <td class="LabelDesign2">MobileNumber</td>
            <td>
                :<asp:Label ID="lblMobileNumber" runat="server" Text="" CssClass="LabelDesign"/>
                

            </td>
            <td class="LabelDesign2">MobileNumber</td>
            <td>
                :<asp:Label ID="lblMobile" runat="server" Text="" CssClass="LabelDesign"/>
                
                
            </td>
            
        </tr>
        <tr>
            <td class="LabelDesign2">DOB</td>
            <td>
                :<asp:Label ID="lblDOB" runat="server" Text="" CssClass="LabelDesign"/>
                

            </td>
            <td><asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="ButtonDesign2" OnClick="btnEdit_Click" /></td>
           
        </tr>
    </table>
    <asp:Label ID="lblMessage" runat="server" Text="" Visible="false"></asp:Label>
</div>

</asp:Panel>
  <asp:Panel ID="Panel2" runat="server" Visible="false" >
<div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-red ">
    <table>
        <tr>
            <td>FirstName</td>
            <td>
               <asp:TextBox ID="txtFirstName" runat="server"  ReadOnly="false" CssClass="TextBoxDesign"></asp:TextBox>
               <br />
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter First Name" ControlToValidate="txtFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>LastName</td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="TextBoxDesign"  ></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Enter Last Name" ControlToValidate="txtLastName" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>  
                <asp:TextBox ID="txtEmail" runat="server" CssClass="TextBoxDesign"  ></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Enter E-mail Id" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*Invalid E-mail" ControlToValidate="txtEmail" ForeColor="red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="TextBoxDesign" ></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Enter Password" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>MobileNumber</td>
            <td>
                <asp:TextBox ID="txtMobileNumber" runat="server"  CssClass="TextBoxDesign" ></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Enter Mobile No" ControlToValidate="txtMobileNumber" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*Invalid Mobile No" ControlToValidate="txtMobileNumber" ForeColor="Red" ValidationExpression="^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[789]\d{9}$"></asp:RegularExpressionValidator>
            </td>
            <td>DOB</td>
            <td>
                <asp:TextBox ID="txtDOB" runat="server" CssClass="TextBoxDesign"   ></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*Enter DOB" ControlToValidate="txtDOB" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RangeValidator ID="RangeValidator1" type="Date" runat="server" minimumvalue="01-01-1999" maximumvalue="01-01-2002" ErrorMessage="*Invalid Date" ControlToValidate="txtDOB" ForeColor="Red"></asp:RangeValidator>
            </td>
            
        </tr>
        <tr>
          
           
            <td><asp:Button ID="Button2" runat="server" Text="Update"  CssClass="ButtonDesign3"  OnClick="btnUpdate_Click" /></td>
        </tr>
    </table>
    <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
</div>

</asp:Panel>
      
 </asp:Content>

