var app = angular.module('nextApp.regras.controllers', []);

app.controller(
    'regraLista', 
    [
        '$scope',
        '$http',
        function($scope, $http){

            $scope.regras = [];
            $scope.carregar = function(){
                $http
                .get("http://localhost:2379/api/regras")
                .success(function(data){
                    $scope.regras = data;
                })
                .error(function(data){
                    console.log(data);
                });
            }
            $scope.deletar = function(id){
                $http
                .delete("http://localhost:2379/api/regras/" + id)
                .success(function(data){
                    $scope.carregar();
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);

app.controller(
    'regraEditar', 
    [
        '$scope',
        '$http',
        '$location',
        '$route',
        function($scope, $http, $location, $route){
            $scope.regra = {};            
            $scope.voltar = function(){ $location.path("/regras"); }
            $scope.carregar = function(){
                $http
                .get("http://localhost:2379/api/regras/" + $route.current.params.id)
                .success(function(data){
                    console.log(data);
                    $scope.regra = data;
                })
                .error(function(data){
                    console.log(data);
                });
            }
            $scope.salvar = function(){
                $http
                .put("http://localhost:2379/api/regras/" + $route.current.params.id, $scope.regra)
                .success(function(data){
                    console.log(data);
                    $location.path("/regras");
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);

app.controller(
    'regraCriar', 
    [
        '$scope',
        '$http',
        '$location',
        '$route',
        function($scope, $http, $location, $route){
            $scope.regra = {};            
            $scope.voltar = function(){ $location.path("/regras"); }
            $scope.salvar = function(){
                $http
                .post("http://localhost:2379/api/regras", $scope.regra)
                .success(function(data){
                    console.log(data);
                    $location.path("/regras");
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);