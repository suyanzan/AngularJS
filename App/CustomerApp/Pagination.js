var app = angular.module('CustApp', ['ui.bootstrap']);//載入app模組

var CustCtrl = function ($scope, $http) {
    $scope.IsLoad = true;//預設讀取中
    //分頁參數
    $scope.totalRecords = 0;
    $scope.pageSize = 10;//每筆頁數
    $scope.currentPage = 1;//初始值，第一頁
    //常有分頁
    $scope.pageChanged = function () {
        $scope.IsLoad = true;//預設讀取中
        GetData();
    }
    var GetData = function () {
        //取得客戶資料
        $http.get('http://localhost:7671/api/Customer', { params: { CurrPage: $scope.currentPage, PageSize: $scope.pageSize } })
        .success(function (response) {
            $scope.Customers = response.Data;
            $scope.totalRecords = response.Total;
            $scope.IsLoad = false;//讀取資料,隱藏loading圖示
        })
        .error(function (data) {
            $scope.error = "取得資料錯誤"
        });
    }
    //Page Load的時候要資料
    GetData();
}