<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assesment.aspx.cs" Inherits="LMS_Web.UI.Trainee.Assesment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <style>
.ButtonDesign{
background-color:  #ff6666;
  border: none;
  color: black;
  padding: 10px;
  text-align: center;
  text-decoration: none;

  font-size: 16px;
  margin: 4px 4px;
  cursor: pointer;
  border-radius: 5px;

} 
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:75%; margin:0 auto;">
              <div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-blue">
                 <h4>
                     <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></h4>
                 <p>TotalMark(<asp:Label ID="lblMarks" runat="server" Text=""></asp:Label>) &nbsp No.Of.Question( <asp:Label ID="lblcounts" runat="server" Text=""></asp:Label>)</p>
                 <p>
                     <asp:Button ID="Button2" runat="server" Text="Start" OnClick="Button2_Click" CssClass="ButtonDesign" /></p>
             </div>
            <asp:Panel ID="Panel1" runat="server" Visible="false">
                <div class="w3-panel w3-round w3-card  w3-white w3-leftbar w3-border-red">
                 <table>
                     <tr>
                         <td>
                              <asp:Label ID="lblQuestion" runat="server" Text=""></asp:Label>
                         </td>
                        
                     </tr>
                     <tr>
                         <td>
                           <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
                         </td>
                      
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="lblMsg" runat="server" Text="" Visible="false"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                       <td>
                         
                           <asp:Button ID="Button1" runat="server" Text="Next" CssClass="ButtonDesign" OnClick="Button1_Click" />
                           <asp:Button ID="btnComplete" runat="server" Text="Finish" CssClass="ButtonDesign" Visible="false" OnClick="btnComplete_Click" />
                         
                       </td>  
                     </tr>
                 </table>
             </div>
            </asp:Panel>
            
            
        </div>
    </form>
</body>
</html>
