// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    //Toggle About
    $(".hideabout").hide()
        $("#about").on("click", function () {
        if ($(".hideabout").is(":hidden")) {
            $(".hideabout").fadeToggle("fast")
        }
        else if ($(".hideabout").is(":visible"))
        {
            $(".hideabout").fadeToggle("fast")
        }

        })

    $("#contact").on("click", function () {

        window.location="Home/index/#contacthere"
    })

})
