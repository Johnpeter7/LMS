<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="LMS_Web.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <style>
       
        .container2{
            width:70%;
            margin:0 auto;
            background-color:#fff;
            border-radius:10px;
            
        }
        .body{
            background-color:#00b3b3;
        }
    </style>
     <title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
</head>
<body class="body"  style= "background-image: url(Blue.png);padding:40px;>
    <form id="form1" runat="server">
       
       
       
       <h3>Sign-Up..</h3>
       <%--<div class="container2">
            <div class="w3-panel w3-round w3-card  ">--%>

              <%--  <div class="form-group">--%>
                    <label for="email">FirstName:</label>
                    <asp:TextBox ID="txtFirstName" runat="server" class="form-control" placeholder="Enter First Name"></asp:TextBox>
                   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter FirstName" ControlToValidate="txtFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <label for="email">LastName:</label>
                    <asp:TextBox ID="txtLastName" runat="server" class="form-control" placeholder="Enter Last Name"></asp:TextBox>
                   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Enter Last Name" ControlToValidate="txtLastName" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <label for="email">Date Of Birth:</label>
                    <asp:TextBox ID="txtDOB" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Enter DOB" ControlToValidate="txtDOB" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <label for="email">Mobile:</label>
                    <asp:TextBox ID="txtMobile" runat="server" class="form-control" placeholder="Enter MobileNumber"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Enter Mobile No" ControlToValidate="txtMobile" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"  ErrorMessage="*Invalid Mobile No" ControlToValidate="txtMobile" ForeColor="Red" ValidationExpression="^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[789]\d{9}$"></asp:RegularExpressionValidator>
                    <br />
                    <label for="email">Department:</label>
                    <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                        <asp:ListItem>---Select---</asp:ListItem>
                        <asp:ListItem>HR</asp:ListItem>
                        <asp:ListItem>PRODUCT</asp:ListItem>
                        <asp:ListItem>BSS</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                         </asp:DropDownList>
                        <br />
                        <label for="email">Email:</label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Enter Mail Id"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Enter E-mail Id" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
               <%--         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*Invalid E-mail" ControlToValidate="txtEmail" ForeColor="red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </div>--%>
                <div class="form-group">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                    </div>
                 
         <%--</div>
        </div>--%>
    </form>
     
    
     
</body>
</html>
