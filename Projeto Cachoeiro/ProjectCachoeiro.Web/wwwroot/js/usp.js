var height = $(window).height();
var mydiv = $(".step");
mydiv.height(height);

$(window).resize(function () {
    height = $(window).height();
    mydiv.height(height);
});

$(document).ready(function () {
    $(".view-element").niceScroll({
        cursorcolor: "#52658C",
        cursorwidth: "12px",
        cursorborder: "0px solid #000",
        scrollspeed: 60,
        autohidemode: false,
        background: '#ddd',
        hidecursordelay: 400,
        cursorfixedheight: false,
        cursorminheight: 20,
        enablekeyboard: true,
        horizrailenabled: true,
        bouncescroll: false,
        smoothscroll: true,
        iframeautoresize: true,
        touchbehavior: false,
        zindex: 9,
        cursorborderradius: "0px"
    });
});