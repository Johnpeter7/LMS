<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LMS_Web.Home" %>

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
    </style>
    
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" runat="server">
</head>
<body style= "background-image: url(Blue.png);padding:180px;">
    <form id="form1" runat="server">
    
<%--             <div class="container2">
                  <div class="w3-panel w3-round w3-card  ">--%>
                       <h3>Login..</h3>
 
    <div class="form-group">
      <label for="email">Email:</label>
        <asp:TextBox ID="txtMailId" runat="server" class="form-control" placeholder="Enter Mail_Id"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter E-mail Id" ControlToValidate="txtMailId" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*Invalid E-mail" ControlToValidate="txtMailId" ForeColor="red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </div>
    <div class="form-group">
      <label for="pwd">Password:</label>
         <asp:TextBox ID="txtPassword" runat="server" class="form-control"  placeholder="Enter Password" TextMode="Password" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Enter Password" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
     <div class="form-group">
         <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-success" OnClick="Button1_Click"/>
         <asp:Button ID="Button2" runat="server" Text="Signup" class="btn btn-primary" OnClick="Button2_Click"/>
        <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
     </div>
   
<%--    </div>
 

</div>--%>
    
       
    </form>
</body>
</html>
