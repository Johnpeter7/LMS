<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="LMS_Web.Master_Template.Trainer.WebUserControl1" %>
<style>
            .ButtonDesign{
background-color:  #ff6666;
  border: none;
  color: black;
  padding: 10px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 4px;
  cursor: pointer;
  border-radius: 5px;
} 
.txtBox{
    width:100%;
padding:12px 40px;
margin:10px 0;
box-sizing:border-box;
border:none;
border-bottom:1px solid black;
}
.txtBoxOption{
     width:70%;
padding:12px 40px;
margin:10px 0;
box-sizing:border-box;
border:none;
border-bottom:1px solid black;
}


    

    .auto-style1 {
        height: 27px;
    }
    .auto-style2 {
        height: 28px;
    }


    

</style>

    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<script  runat="server">
//protected void Button1_Click1(object sender, EventArgs e)
//{
//    //Label2.Visible = true;
//    //Label2.Text = TextBox3.Text;
//    RadioButtonList radioButtonList = new RadioButtonList();
//    if(radioButtonList.Items.Count <= 3)
//    {
//        ListItem listItem = new ListItem();
//        listItem.Text = TextBox1.Text.ToString();
//        radioButtonList.Items.Add(listItem);
//        Panel1.Controls.Add(radioButtonList);
//        RadioButtonList1.Visible = true;
//    }

//    //if (RadioButtonList1.Items.Count <= 3)
//    //{
//    //    ListItem listItem = new ListItem();
//    //    listItem.Text = TextBox1.Text.ToString();
//    //    RadioButtonList1.Items.Add(listItem);
//    //    Label2.Visible = true;
//    //    Label2.Text = RadioButtonList1.SelectedItem.Text;
//    //}
//    else
//    {
//        Label1.Visible = true;
//        Label1.Text = "Limit Exit";
//        TextBox1.Visible = false;
//        Button1.Visible = false;
//        TextBox1.Visible = false;
//    }


//}

//protected void Button1_Click2(object sender, EventArgs e)
//{
//    Label4.Visible = true;
//    Label4.Text = RadioButtonList1.DataTextField.ToString();

//    if (RadioButtonList2.Items.Count <= 3)
//    {
//        ListItem listItem = new ListItem();
//        listItem.Text = TextBox2.Text.ToString();
//        RadioButtonList2.Items.Add(listItem);

//    }
//    else
//    {
//        Label3.Visible = true;
//        Label3.Text = "Limit Exit";
//        TextBox3.Visible = false;
//        Button2.Visible = false;
//        TextBox2.Visible = false;
//    }
//}
//protected void Button1_Click3(object sender, EventArgs e)
//{
//     Label6.Visible = true;
//     Label6.Text = TextBox5.Text;

//  if (RadioButtonList3.Items.Count <= 3)
//  {
//      ListItem listItem = new ListItem();
//      listItem.Text = TextBox3.Text.ToString();
//      RadioButtonList3.Items.Add(listItem);

//  }
//  else
//  {
//      Label5.Visible = true;
//      Label5.Text = "Limit Exit";
//      TextBox5.Visible = false;
//      Button3.Visible = false;
//      TextBox3.Visible = false;
//  }

//  }

//protected void Button1_Click4(object sender, EventArgs e)
//{
//    Label label = new Label();
//    label.Text = TextBox2.Text;
//    Panel1.Controls.Add(label);
//    RadioButtonList radioButtonList = new RadioButtonList();
//    radioButtonList.Items.Add(TextBox3.Text);
//    radioButtonList.Items.Add(TextBox4.Text);
//    radioButtonList.Items.Add(TextBox5.Text);
//    radioButtonList.Items.Add(TextBox6.Text);
//    Panel1.Controls.Add(radioButtonList);
//    Button btn = new Button();
//    btn.CssClass = "ButtonDesign";
//    btn.Click += new EventHandler(DynamicButton);


//}
//private void DynamicButton(object sender,EventArgs e)
//{

//}
</script>
<div>
     <h4>Create Assesment for <asp:Label ID="lbltitletxt" runat="server" Text="" Visible="false"></asp:Label></h4>
    <asp:Panel ID="Panel3" runat="server">
        <table>
            <tr>
                <td>
                    Title:-
                </td>
                <td>
                     <asp:TextBox ID="txtTitle" runat="server" PlaceHolder="Title" CssClass="txtBox" ></asp:TextBox>
                     <br />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter Title" ControlToValidate="txtTitle" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td>Date</td>
                <td>
                     <asp:TextBox ID="txtDate" runat="server" PlaceHolder="Title" CssClass="txtBox" TextMode="Date" ></asp:TextBox>
                     <br />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Enter Date" ControlToValidate="txtDate" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                 <td><asp:Button ID="CreateAssesment" runat="server" Text="Create"  CssClass="ButtonDesign" OnClick="btn_CreateAssement" /></td>
            </tr>
        </table>

    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Visible="false">
   <table>
    <%--<tr>
        <td>
            <asp:TextBox ID="txtTitle" runat="server" PlaceHolder="Title" CssClass="txtBox"></asp:TextBox></td>
        
         
    </tr>--%>
      <tr>
          <td> <asp:TextBox ID="txtQuestion" runat="server" PlaceHolder="Question" CssClass="txtBox" />
               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Enter The Question" ControlToValidate="txtQuestion" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
          <td> <asp:TextBox ID="txtOption1" runat="server" PlaceHolder="Option1" CssClass="txtBoxOption" /><br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Enter The Option" ControlToValidate="txtOption1" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
          <td> <asp:TextBox ID="txtOption2" runat="server" PlaceHolder="Option2" CssClass="txtBoxOption" /><br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Enter The Option" ControlToValidate="txtOption2" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
      </tr>
       <tr>
          <td> <asp:TextBox ID="txtOption3" runat="server" PlaceHolder="Option3" CssClass="txtBoxOption" /><br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*Enter The Option" ControlToValidate="txtOption3" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
          <td> <asp:TextBox ID="txtOption4" runat="server" PlaceHolder="Option4" CssClass="txtBoxOption" /><br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*Enter The Option" ControlToValidate="txtOption4" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
          <td>
              <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="Create_btn" CssClass="ButtonDesign" /></td>
      </tr>
  </table>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" Visible="false">
        <table>
            <tr>
                <td style="font-size:20px;">Title:-
                    <asp:Label ID="lblTitle" runat="server" Text="" ></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblQuestion" runat="server" Text="Label"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:RadioButtonList ID="RadioButtonListOption" runat="server"></asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnUpload" runat="server" Text="Upload"  CssClass="ButtonDesign" OnClick="btnUpload_Click" /></td>
                <td>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="ButtonDesign" OnClick="btnEdit_Click"  /></td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerrormsg" runat="server" Text="" Visible="false"></asp:Label></td>
            </tr>
        </table>

    </asp:Panel>
</div>




