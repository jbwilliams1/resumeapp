angular.module('resumeApp', [])
.controller('ResumeController', ['ResumeService', '$scope', '$window', '$timeout' , function(ResumeService, $scope, $window, $timeout) {
    $scope.loading = true;
    $scope.employeeID = 1; // Hardcoded because it's just me!

    // Could've combined these into an object but I wanted more content
    $scope.employee = null;
    $scope.jobs = null;
    $scope.skills = null;

    $scope.init = function() {
        getEmployeeByID($scope.employeeID);
    }

    function getEmployeeByID(employeeID) {        
        return ResumeService.getEmployeeByID(employeeID).then(function (data) {
            if (data) {
                $scope.employee = data;
                $scope.loading = false;
            
                getSkillsByEmployeeID($scope.employee.id);
                getJobsByEmployeeID($scope.employee.id);
            } else {
                $window.alert("Weird. No employee by that ID exists!")
            }
        });
    }

    function getSkillsByEmployeeID(employeeID) {
        return ResumeService.getSkillsByEmployeeID(employeeID).then(function (data) {
            if (data) {
                $scope.skills = data;
            } else {
                $window.alert("Employee has NO SKILLS WHATSOEVER");
            }
        });
    }

    function getJobsByEmployeeID(employeeID) {
        return ResumeService.getJobsByEmployeeID(employeeID).then(function(data) {
            if (data) {
                $scope.jobs = data;
            } else {
                $window.alert("Employee has never had a job. Maybe you should hire them.");
            }
        });
    }

    $timeout(function(){ console.log("Perceived loading is nice for UX!"); $scope.init()}, 2000);
}])
.service('ResumeService', ['$http', function($http){
    return {
        'getEmployeeByID'       : getEmployeeByID,
        'getSkillsByEmployeeID' : getSkillsByEmployeeID,
        'getJobsByEmployeeID'   : getJobsByEmployeeID
    };

    function getEmployeeByID(employeeID) {
        return $http({
            url     : '/resume/getEmployeeByID',
            method  : "GET",
            params  : { "employeeID" : employeeID } 
        }).then(function(response){
            return response.data;
        });    
    }

    function getSkillsByEmployeeID(employeeID) {
        return $http({
            url     : '/resume/getSkillsByEmployeeID',
            method  : "GET",
            params  : { "employeeID" : employeeID } 
        }).then(function(response){
            return response.data;
        });    
    }

    function getJobsByEmployeeID(employeeID) {
        return $http({
            url     : '/resume/getJobsByEmployeeID',
            method  : "GET",
            params  : { "employeeID" : employeeID } 
        }).then(function(response){
            return response.data;
        });    
    }
}])
.config(function($sceProvider) {
    $sceProvider.enabled(false); // For purposes of this demo
});