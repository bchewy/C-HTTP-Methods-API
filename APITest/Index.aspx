<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="APITest.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--
    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table" EmptyDataText="No data is shown">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    -->
    <div class="container-fluid">
        <div class="jumbotron-fluid container">
            <h1>POST HTTP Method</h1>
            <p class="lead">The post method here will launch a post request to the api, adding a new user! you'll be able to see a json response at the bottom</p>
            <div class="form-group">
                Username
            <asp:TextBox ID="tbUsername" runat="server" CssClass="form-control"></asp:TextBox>
                Job
            <asp:TextBox ID="tbJob" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Button ID="btnAddUser" runat="server" Text="Add user" CssClass="form-control btn btn-primary" OnClick="btnAddUser_Click" />

            </div>
        </div>
        <hr class="bg-dark" />
        <div class="jumbotron-fluid container">
            <h1>GET HTTP Method</h1>
            <p class="lead">The GET method here will retrieve users from the database... in this case it will return this response <a href="https://reqres.in/api/users?page=2">https://reqres.in/api/users?page=2</a></p>

            <div class="form-group">
                <asp:Button ID="btnGetUsers" runat="server" Text="Get something" OnClick="Button1_Click" CssClass="form-control btn btn-primary" />

            </div>
        </div>
        <div class="bg-lights jumbotron text-center">
            <h6>Response commands</h6>
            <asp:Button ID="btnClear" runat="server" Text="Clear response" OnClick="btnClear_Click" CssClass="btn-rounded btn-sm btn-danger m-2" /><br />
            <div class="container text-left border-danger px-5 pb-5">
                <h3>Response:</h3>

                <asp:Label ID="lbl" runat="server" Text="" CssClass=""></asp:Label>
            </div>
                    <footer class="text-center">
            <a href="https://reqres.in/">API that was used</a>
        </footer>
        </div>




</asp:Content>
