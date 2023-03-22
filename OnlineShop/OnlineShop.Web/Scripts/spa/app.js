/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);
myApp.controller('schoolController', schoolController);
myApp.service('validatorService', Validator);
myApp.directive('onlineShopDirective', onlineShopDirective);

schoolController.$inject = ['$scope', 'validatorService'];

//declare
function schoolController($scope, validatorService) {
    $scope.checkNumber = function () {
        $scope.message = validatorService.checkNumber(2);
    }

    $scope.num = 1;
}

//custom service
function Validator($window) {
    return {
        checkNumber: checkNumber
    }

    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        } else {
            return 'This is odd';
        }
    }
}

//function onlineShopDirective() {
//    return {
//        template: "<h1>This is my first custom directive</h1>"
//    }
//}

function onlineShopDirective() {
    return {
        templateUrl: "/Scripts/spa/onlineShopDirective.html"
    }
}


