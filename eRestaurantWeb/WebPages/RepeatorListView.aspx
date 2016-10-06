<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RepeatorListView.aspx.cs" Inherits="WebPages_RepeatorListView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <h1>Nested Repeator</h1>
    <!--_the outer repeator is for each row in the overall data set-->
    <asp:Repeater ID="FoodItemOutter" runat="server" DataSourceID="MenuCateFoodItemODS">
        <ItemTemplate>
            <h3><%# Eval("MenuCategoryDescription") %></h3>
            <!--_the inner repeator will handle the List<T>
                    that is on each row of the overall data set-->
            <asp:Repeater ID="FoodItemInner" runat="server" DataSource='<%# Eval("FoodItems") %>'>
                <ItemTemplate>
                    <%# Eval("ItemID") %>&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("FoodDescription") %>'></asp:Label>
                    <%# ((decimal)Eval("CurrentPrice")).ToString("C") %>&nbsp;&nbsp;&nbsp;
                    <span class="badge"><%# Eval("TimesServed") %>Serving</span>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </ItemTemplate>
    </asp:Repeater>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="MenuCateFoodItemODS">
        <ItemTemplate>
            <h3><%# Eval("MenuCategoryDescription") %></h3>
            <!--_the inner repeator will handle the List<T>
                    that is on each row of the overall data set-->
            <asp:ListView ID="ListView1" runat="server" DataSource='<%# Eval("FoodItems") %>'>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%# Eval("ItemID") %>

                        </td>
                        <td>
                            <%# Eval("FoodDescription") %>
                        </td>
                        <td>
                            <%# ((decimal)Eval("CurrentPrice")).ToString("C") %>
                        </td>
                        <td>
                            <span class="badge"><%# Eval("TimesServed") %>Serving</span>
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <th runat="server">ID</th>
                            <th runat="server">Item</th>
                            <th runat="server">$</th>
                            <th runat="server">Servings</th>
                        </tr>
                        <tr runat="server" id="itemPlaceHolder"></tr>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </ItemTemplate>
    </asp:Repeater>
    <asp:ObjectDataSource ID="MenuCateFoodItemODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="MenuCategoryFoodItemDTO_Get" TypeName="eRestaurantSystem.BLL.ItemController"></asp:ObjectDataSource>
</asp:Content>

