$(document).ready(function () {
    $.fn.clickToggle = function (func1, func2) {
        var funcs = [func1, func2];
        this.data('toggleclicked', 0);
        this.click(function () {
            var data = $(this).data();
            var tc = data.toggleclicked;
            $.proxy(funcs[tc], this)();
            data.toggleclicked = (tc + 1) % 2;
        });
        return this;
    };
    if ($(window).width() <= 895) {
        $("nav").css("display", "none");
        $("nav ul li").click(function () {
            $(this).find("ul").toggle();
        });
    } else {
        $("nav").css("display", "block");
    }
    $(".hamburger").click(function () {
        $("nav").slideToggle("fast");
        if ($(window).width() > 400) {
            //$(".logo-written").toggle();
        }
    });

    $(".minimenu-search").click(function () {
        $(".minimenu-search-box").toggle(250);
    });
});