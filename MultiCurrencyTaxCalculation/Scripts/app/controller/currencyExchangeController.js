currencyExchangeModule.controller('currencyExchangeController', ['$scope', 'moneyRepository', 'currencyRepository', 'countryRepository', 'taxCategoryRepository', 'taxYearRepository', 'taxRepository',
    function ($scope, moneyRepository, currencyRepository, countryRepository, taxCategoryRepository, taxYearRepository, taxRepository) {
    getCurrencies();
    function getCurrencies() {
        
        var promise = currencyRepository.getCurrencies();
        promise.then(function (currencies) {            
            $scope.currencies = currencies;
            
        }, function (reason) {
            alert('Failed: ' + reason);
        }, function (update) {
            alert('Got notification: ' + update);
        });
    };

    getCountries();
    function getCountries() {

        var promise = countryRepository.getCountries();
        promise.then(function (countries) {
            $scope.countries = countries;

        }, function (reason) {
            alert('Failed: ' + reason);
        }, function (update) {
            alert('Got notification: ' + update);
        });
    };


    $scope.convertNetPayCurrency = function convertNetPayCurrency(amount, fromCurrency, targetCurrency) {
        var promise = moneyRepository.convertCurrency(amount, fromCurrency, targetCurrency);
        promise.then(function (convertedAmount) {
            $scope.taxBreakdown.netPay = convertedAmount;
        }, function (reason) {
            alert('Failed: ' + reason);
        }, function (update) {
            alert('Got notification: ' + update);
        });
    };

    $scope.convertGrossPayCurrency = function convertGrossPayCurrency(amount, fromCurrency, targetCurrency) {
        var promise = moneyRepository.convertCurrency(amount, fromCurrency, targetCurrency);
        promise.then(function (convertedAmount) {
            $scope.taxBreakdown.grossPay = convertedAmount;
        }, function (reason) {
            alert('Failed: ' + reason);
        }, function (update) {
            alert('Got notification: ' + update);
        });
    };

    $scope.getTaxDetailsByCountry = function getTaxDetailsByCountry() {
        var promise = taxCategoryRepository.getTaxCategories($scope.taxParameters.expatCountry.countryId);
        promise.then(function (taxCategories) {
            $scope.taxCategories = taxCategories;
            var currency = $scope.currencies.filter(function (x) { return x.countryId == $scope.taxParameters.expatCountry.countryId; });
            $scope.baseCurrency = currency[0];
            $scope.taxParameters.sourceCurrency = currency[0];
            $scope.taxParameters.targetCurrency = currency[0];
        }, function (reason) {
            alert('Failed: ' + reason);
        }, function (update) {
            alert('Got notification: ' + update);
        });

        var promise = taxYearRepository.getTaxYear($scope.taxParameters.expatCountry.countryId);
        promise.then(function (taxYears) {
            $scope.taxYears = taxYears;
        }, function (reason) {
            alert('Failed: ' + reason);
        }, function (update) {
            alert('Got notification: ' + update);
        });
    };

    $scope.calculateTax = function calculateTax() {
        var promise = taxRepository.calculateTax($scope.taxParameters);
        promise.then(function (taxBreakdown) {
            $scope.taxBreakdown = taxBreakdown;
        }, function (reason) {
            alert('Failed: ' + reason);
        }, function (update) {
            alert('Got notification: ' + update);
        });
    };
}]);