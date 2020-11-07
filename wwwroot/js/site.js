// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    $("#btn1").click(function () {
        $("#btn1").html("<b>Test for gulpfile.js!</b>");
    })

    $("#musicSlider").carousel({
        interval: false,
        wrap: false
    });

    var checkitem = function () {
        var $this;
        $this = $("#musicSlider");
        if ($("#musicSlider .carousel-inner .item:first").hasClass("active")) {
            $this.children(".carousel-control-prev").hide();
            $this.children(".carousel-control-next").show();
        } else if ($("#musicSlider .carousel-inner .item:last").hasClass("active")) {
            $this.children(".carousel-control-next").hide();
            $this.children(".carousel-control-prev").show();
        } else {
            $this.children(".carousel-control").show();
        }
    };

    checkitem();

    $("#musicSlider").on("slid.bs.carousel", "", checkitem);

});