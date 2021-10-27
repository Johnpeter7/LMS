<%@ Page Title="" Language="C#" MasterPageFile="../../Master_Template/Trainee/TraineeGroupDashBoard.Master" AutoEventWireup="true" CodeBehind="ReadingMaterials.aspx.cs" Inherits="LMS_Web.UI.Trainee.ReadingMaterials" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentTraineeGroups" runat="server">
    <asp:Panel ID="Panel1" runat="server" >
        <a style="text-decoration:none;"href="ReadingMaterialsData.aspx?type=1">
     <div class="w3-panel w3-card w3-border w3-round">
    <h3 style="color:#000;">Images<i class="fas fa-fw fa-image" style="color:#ff6666;"></i>!</h3>
    <p>Total No of Files(2).</p>
  </div>
        </a>
    <a style="text-decoration:none;" href="ReadingMaterialsData.aspx?type=2">
     <div class="w3-panel w3-card w3-border w3-round">
    <h3 style="color:#000;">Docs<i class="fas fa-fw fa-file-pdf" style="color:#ff6666;"></i>!</h3>
    <p>Total No of Files(2).</p>
  </div>
    </a>
 <a style="text-decoration:none;" href="ReadingMaterialsData.aspx?type=3">
      <div class="w3-panel w3-card w3-border w3-round">
    <h3 style="color:#000;">Video<i class="fas fa-fw fa-video" style="color:#ff6666;"></i>!</h3>
    <p>Total No of Files(2).</p>
  </div>
 </a>
  
    </asp:Panel>
</asp:Content>
