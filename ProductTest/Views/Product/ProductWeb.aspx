<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductWeb.aspx.cs" Inherits="ProductTest.Views.Product.ProductWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="../../Scripts/ProductScript/ProductScript.js"></script>
    <title></title>

</head>
<body>
      <div class="container">
        <button type="submit" class="btn btn-default" id="BtnAdd">ADD</button>
        <button type="submit" class="btn btn-default" id="BtnUpdate">UPDATE</button>
        <button type="submit" class="btn btn-default" id="BtnDelete">DELETE</button>
      </div>

      <div class="container">
          <div class="form-group" id="AddData">
                  <label for="ProductId">Product ID : </label>
                  <input type="text" class="form-control" id="ProductID" />
                  <label for="ProductName">Product Name : </label>
                  <input type="text" class="form-control" id="ProductName" />
                  <label for="ProductPrice">Product Price : </label>
                  <input type="text" class="form-control" id="ProductPrice" />
                  <button type="submit" class="btn btn-default" id="SubmitAddData">Submit</button>
          </div>
      </div>
      <div class="container">
          <div class="form-group" id="UpdateData">
                  <label for="ProductId">Product ID : </label>
                  <input type="text" class="form-control" id="updateProductID" />
                  <label for="ProductName">Product Name : </label>
                  <input type="text" class="form-control" id="updateProductName" />
                  <label for="ProductPrice">Product Price : </label>
                  <input type="text" class="form-control" id="updateProductPrice" />
                  <button type="submit" class="btn btn-default" id="Submitupdate">Update</button>
          </div>
      </div>
</body>
</html>
