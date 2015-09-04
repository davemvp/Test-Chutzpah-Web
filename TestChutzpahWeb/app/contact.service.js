(function () {
    'use strict';

    angular
        .module('app')
        .factory('contactService', contactService);

    contactService.$inject = ['$http', '$q'];

    function contactService($http, $q) {
        var service = {
            getData: getData
        };

        return service;

        function getData() { }        
    }
})();