using BusinessLayer.Assesment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Assement;

namespace LMS_Web.Master_Template.Trainer
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Create_btn(object sender, EventArgs e)
        {
             int count = 0;
             count = Convert.ToInt32(ViewState["Count"]);
            //ViewState["Count"] = 0;
            //int count =Convert.ToInt32( ViewState["Count"]);
            if (count == 0)
            {

                Panel1.Visible = false;
                lblTitle.Text = txtTitle.Text;
                lblQuestion.Text = txtQuestion.Text;
                RadioButtonListOption.Items.Add(txtOption1.Text);
                RadioButtonListOption.Items.Add(txtOption2.Text);
                RadioButtonListOption.Items.Add(txtOption3.Text);
                RadioButtonListOption.Items.Add(txtOption4.Text);
                Panel2.Visible = true;
                ViewState["Count"] = 1;
            }
            else
            {
                btnCreate.Visible = true;
                Panel1.Visible = false;
                lblTitle.Text = txtTitle.Text;
                lblQuestion.Text = txtQuestion.Text;
                RadioButtonListOption.Items.Add(txtOption1.Text);
                RadioButtonListOption.Items.Add(txtOption2.Text);
                RadioButtonListOption.Items.Add(txtOption3.Text);
                RadioButtonListOption.Items.Add(txtOption4.Text);
                Panel2.Visible = true;

            }
            
        }

        private void DynamicButton(object sender, EventArgs e)
        {
           
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            RadioButtonListOption.Items.Clear();
            Panel2.Visible = false;
            Panel1.Visible = true;
            
        }

        protected void btn_CreateAssement(object sender, EventArgs e)
        {
            int AssesmentId = 0;
            AssesmentViewModal assesmentViewModal = new AssesmentViewModal();
            assesmentViewModal.AssignDate = Convert.ToDateTime(txtDate.Text);
            assesmentViewModal.Group_Id = Convert.ToInt32(Session["Group_Id"]);
            assesmentViewModal.Title = txtTitle.Text;
            AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
            AssesmentId=assesmentBusinessLayer.CreateAssesment(assesmentViewModal);
            ViewState["AssesmentId"] = AssesmentId;
            Panel3.Visible = false;
            lbltitletxt.Visible = true;
            lbltitletxt.Text = txtTitle.Text;
            Panel1.Visible = true;


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if(RadioButtonListOption.SelectedIndex != 0)
            {
                AssesmentInfoViewModal assesmentInfoViewModal=new AssesmentInfoViewModal();
                assesmentInfoViewModal.Assesment_Id =Convert.ToInt32( ViewState["AssesmentId"]);
                assesmentInfoViewModal.Question = txtQuestion.Text;
                assesmentInfoViewModal.Option1 = txtOption1.Text;
                assesmentInfoViewModal.Option2 = txtOption2.Text;
                assesmentInfoViewModal.Option3 = txtOption3.Text;
                assesmentInfoViewModal.Option4 = txtOption4.Text;
                assesmentInfoViewModal.CorrectOption = RadioButtonListOption.SelectedItem.Text;
                AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
                assesmentBusinessLayer.AssesmentInfo(assesmentInfoViewModal);
                txtQuestion.Text = "";
                txtOption1.Text = "";
                txtOption2.Text = "";
                txtOption3.Text = "";
                txtOption4.Text = "";
                RadioButtonListOption.Items.Clear();
                Panel2.Visible = false;
                Panel1.Visible = true;
            }
            else
            {
                lblerrormsg.Visible = true;
                lblerrormsg.Text = "PLEASE SELECT CORRECT ANSWER...";
            }
        }

        protected void finish_btn(object sender, EventArgs e)
        {
            Response.Redirect("TrainerDashBoard.aspx");
        }



        //protected void Button1_Click1(object sender, EventArgs e)
        //{
        //    Label4.Visible = true;
        //    Label4.Text = TextArea2.Value;

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
        //        TextArea2.Visible = false;
        //        Button2.Visible = false;
        //        TextBox2.Visible = false;
        //    }


        //}
    }
}