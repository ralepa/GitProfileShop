var localhost = window.location.hostname;
var serverPort = '54986';
var apiURL = 'http://'+localhost + ':' + serverPort;


($(document).ready(function ()
{
    $.get(apiURL + "/cart", function (user) {
        addItemToList(user);
    });

    $('#addButton').on('click', function (e) {

        var userName = $('#userName').val();
        if (userName == '' || userName == null)
        {
            return null;
        }

        $.get(apiURL + "/users/" + userName, function (user) {
            addItemToList(user);
        });
    });
    
}))
