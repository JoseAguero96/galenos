<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Galenos.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="carouselExampleControls" class="carousel slide" data-ride="carousel" style="height:350px;">
      <div class="carousel-inner">
        <div class="carousel-item">
          <img class="d-block w-100" data-src="holder.js/800x400?auto=yes&amp;bg=777&amp;fg=555&amp;text=First slide" alt="First slide [800x400]" src="../images/img1.jpg" data-holder-rendered="true" style="height:350px;">
        </div>
        <div class="carousel-item active">
          <img class="d-block w-100" data-src="holder.js/800x400?auto=yes&amp;bg=666&amp;fg=444&amp;text=Second slide" alt="Second slide [800x400]" src="../images/img1.jpg" data-holder-rendered="true" style="height:350px;">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100" data-src="holder.js/800x400?auto=yes&amp;bg=555&amp;fg=333&amp;text=Third slide" alt="Third slide [800x400]" src="../images/img1.jpg" data-holder-rendered="true" style="height:350px;">
        </div>
      </div>
      <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>
    <table class="table"><tbody><tr><td>
        <div class="card text-white bg-secondary mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td><td>
        <div class="card text-white bg-warning mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td><td>
        <div class="card text-white bg-danger mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td><td>
        <div class="card text-white bg-info mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td></tr><tr><td>
        <div class="card text-white bg-dark mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td><td>
        <div class="card text-white bg-info mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td><td>
        <div class="card text-white bg-success mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td><td>
        <div class="card text-white bg-ultimo mb-3" style="max-width: 18rem;">
          <div class="card-header">Oncología</div>
          <div class="card-body">
            <h5 class="card-title">Misteriosa causa del cáncer de mama</h5>
            <p class="card-text">Cientificos descubren que el cáncer de mama da por no ser de la U.</p>
          </div>
        </div>
    </td></tr></tbody></table>


    <asp:Label ID="lblProbando" runat="server" Text=""></asp:Label>
</asp:Content>
