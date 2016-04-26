var app = angular.module('myApp', ['ngRoute', 'ngAnimate'])

app.config(function ($routeProvider) {
    $routeProvider
        // q1 page
        .when('/', {
            templateUrl: 'q1',
            controller: 'q1Ctrl'
        })
        // q2 page
        .when('/q2', {
            templateUrl: 'q2',
            controller: 'q2Ctrl'
        })
        // q3 page
        .when('/q3', {
            templateUrl: 'q3',
            controller: 'q3Ctrl'
        })
        // result page
        .when('/calc', {
            templateUrl: 'calc',
            controller: 'calc'
        });
});

// Init variables
app.factory('items', function () {
    var items = {
        rent: 0,
        mortgage: 0,
        children: 0,
        debt: 0
    };

    var itemsService = {};

    itemsService.set = function (item, val) {
        items[item] = val;
    };
    itemsService.list = function () {
        return items;
    };

    return itemsService;
});

app.controller("q1Ctrl", function ($scope, items, $http) {
    $scope.pageClass = "page-q1";
    $scope.rent = 0;
    $scope.mortgage = 0;

    $scope.change = function () {
        items.set("rent", $scope.rent);
        items.set("mortgage", $scope.mortgage);
    }

});

app.controller("q2Ctrl", function ($scope, items) {
    $scope.pageClass = "page-q2";
    $scope.children = 0;
    $scope.change = function () {
        items.set("children", $scope.children);
    }
});

app.controller("q3Ctrl", function ($scope, items, $rootScope) {
    $scope.pageClass = "page-q3";
    $scope.debt = 0;
    $scope.change = function () {
        items.set("debt", $scope.debt);
    }
});

app.controller("calc", function ($scope, items, $http, $filter) {
    $scope.pageClass = "page-calc";
    $scope.alert = "success";

    $http({
        method: "POST",
        url: "/api/insurance/calculateCoverAmount",
        data: items.list()
    }).then(function mySuccess(response) {
        if (!angular.isNumber(response.data)) {
            $scope.result = response.data;
            $scope.alert = "danger";
        }
        else {
            $scope.result = $filter('currency')(response.data);
        }

    });
});