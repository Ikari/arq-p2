var app = angular.module('nextApp', 
                [
                    'ngRoute', 
                    'nextApp.clientes.controllers', 
                    'nextApp.produtos.controllers', 
                    'nextApp.regras.controllers'
                ]);

app.config([
    '$routeProvider',
    function($routeProvider){
        /*clientes*/
        $routeProvider.when('/clientes/novo', { templateUrl:'views/clientes/criar.html', controller: 'clienteCriar' });
        $routeProvider.when('/clientes/:id', { templateUrl:'views/clientes/editar.html', controller: 'clienteEditar' });        
        $routeProvider.when('/clientes', { templateUrl:'views/clientes/listar.html', controller: 'clientesLista' });
        /*produtos*/
        $routeProvider.when('/produtos/novo', { templateUrl:'views/produtos/criar.html', controller: 'produtoCriar' });
        $routeProvider.when('/produtos/:id', { templateUrl:'views/produtos/editar.html', controller: 'produtoEditar' });        
        $routeProvider.when('/produtos', { templateUrl:'views/produtos/listar.html', controller: 'produtoLista' });
        /*regras*/
        $routeProvider.when('/regras/novo', { templateUrl:'views/regras/criar.html', controller: 'regraCriar' });
        $routeProvider.when('/regras/:id', { templateUrl:'views/regras/editar.html', controller: 'regraEditar' });        
        $routeProvider.when('/regras', { templateUrl:'views/regras/listar.html', controller: 'regraLista' });
        /*default*/
        $routeProvider.otherwise({ redirectTo: "/clientes" });
    }
]);

app.run();