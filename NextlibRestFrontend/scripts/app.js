var app = angular.module('nextApp', ['ngRoute', 'nextApp.clientes.controllers']);

app.config([
    '$routeProvider',
    function($routeProvider){
        /*
        $routeProvider.when('/genre', { templateUrl:'views/new.html', controller: 'newgenreController' });
        
        */
        $routeProvider.when('/clientes/:id', { templateUrl:'views/clientes/editar.html', controller: 'clienteEditar' });        
        $routeProvider.when('/clientes', { templateUrl:'views/clientes/listar.html', controller: 'clientesLista' });
        $routeProvider.otherwise({ redirectTo: "/clientes" });
    }
]);

app.run();