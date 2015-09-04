(function () {
    'use strict';

    angular
        .module('app')
        .controller('ContactController', contactController);

    contactController.$inject = ['$location', 'contactService'];

    function contactController($location, contactService) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'Contact us';

        activate();

        function activate() { }
    }
})();
