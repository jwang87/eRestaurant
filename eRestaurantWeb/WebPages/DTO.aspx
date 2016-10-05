<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DTO.aspx.cs" Inherits="WebPages_DTO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="MenuCategoryFoodItems" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="MenuCategoryDestription" HeaderText="MenuCategoryDestription" SortExpression="MenuCategoryDestription"></asp:BoundField>
            <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID"></asp:BoundField>
            <asp:BoundField DataField="FoodDescription" HeaderText="FoodDescription" SortExpression="FoodDescription"></asp:BoundField>
            <asp:BoundField DataField="CurrentPrice" HeaderText="CurrentPrice" SortExpression="CurrentPrice"></asp:BoundField>
            <asp:BoundField DataField="TimesServed" HeaderText="TimesServed" SortExpression="TimesServed"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:GridView ID="DTO" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
        <Columns>
            <asp:BoundField DataField="MenuCategoryDescription" HeaderText="MenuCategoryDescription" 
                SortExpression="MenuCategoryDescription"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="MenueCategoryFoodItem_Get" TypeName="eRestaurantSystem.BLL.ItemController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="MenuCategoryFoodItemDTO_Get" TypeName="eRestaurantSystem.BLL.ItemController"></asp:ObjectDataSource>
</asp:Content>

