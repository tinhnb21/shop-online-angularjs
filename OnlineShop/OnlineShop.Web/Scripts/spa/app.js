/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);
myApp.controller('schoolController', schoolController);
myApp.service('Validator', Validator);

schoolController.$inject = ['$scope', 'Validator'];

//declare
function schoolController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber(2);
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