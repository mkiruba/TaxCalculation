currencyExchangeModule.factory('currencyRepository', function ($http, $q) {
    return {
        getCurrencies: function (currencies) {
            var deferred = $q.defer();
            $http({
                method: 'GET',
                url: '/api/currency', data: currencies
            })
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }
    };
});

currencyExchangeModule.factory('moneyRepository', function ($http, $q) {
    return {
        convertCurrency: function (amount, fromCurrency, targetCurrency) {
            var deferred = $q.defer();
            fx.base = "USD";
            fx.rates = {
                "AED": 3.672959,
                "AUD": 1.077981,
                "CAD": 1.096752,
                "CHF": 0.905713,
                "EUR": 0.745101,
                "GBP": 0.647710,
                "HKD": 7.751496,
                "INR": 61.16807,
                "MYR": 3.204115,
                "SAR": 3.750401,
                "SGD": 1.252142,
                "USD": 1,
            }

            var convertedAmount = fx.convert(amount, { to: targetCurrency, from: fromCurrency });
            deferred.resolve(convertedAmount);
            return deferred.promise;
        }
    };
});

currencyExchangeModule.factory('countryRepository', function ($http, $q) {
    return {
        getCountries: function (countries) {
            var deferred = $q.defer();
            $http({
                method: 'GET',
                url: '/api/country', data: countries
            })
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }
    };
});

currencyExchangeModule.factory('taxCategoryRepository', function ($http, $q) {
    return {
        getTaxCategories: function (id, taxCategories) {
            var deferred = $q.defer();
            $http({
                method: 'GET',
                url: '/api/taxcategory',
                params: {id:id},
                data: taxCategories
            })
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }
    };
});

currencyExchangeModule.factory('taxYearRepository', function ($http, $q) {
    return {
        getTaxYear: function (id, taxYears) {
            var deferred = $q.defer();
            $http({
                method: 'GET',
                url: '/api/taxyear',
                params: { id: id },
                data: taxYears
            })
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }
    };
});


currencyExchangeModule.factory('taxRepository', function ($http, $q) {
    return {
        calculateTax: function (taxParameters) {
            var deferred = $q.defer();
            $http({
                method: 'POST',
                url: '/api/tax',                
                data: taxParameters
            })
                .success(function (data) {
                    deferred.resolve(data);
                })
                .error(function (error) {
                    deferred.reject(error);
                });

            return deferred.promise;
        }
    };
});