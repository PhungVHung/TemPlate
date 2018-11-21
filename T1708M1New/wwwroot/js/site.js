// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript
$validator.addMethod('validate'), function (inputValue, inputElement, _LyCuongFirstName)
    if (inputValue.indexOf(_LyCuongFirstName) >= 0) {
        return false;
}
return true;
});
$validator.unobtrusive.adapters.add('cuong', ['lycuong'], function (options) {
    var paraFirstName = options.params['lycuong'];
    options.rules['validate'] = paraFirstName;
    options.messages['validate'] = options.messages;
}
);