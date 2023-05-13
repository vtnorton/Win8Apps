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
    $(".hamburguer").clickToggle(function () {
        $(".logo-logo").hide();
        $("#cssmenu span").hide();
        $(".logo").css("width", "67px");
        $(".content").css("padding", "60px 10px 10px 77px");
        $(".hamburguer").css("left", "67px");
        $("#cssmenu").css("width", "67px");
    }, function () {
        $(".logo-logo").show();
        $("#cssmenu span").show();
        $(".logo").css("width", "290px");
        $(".content").css("padding", "60px 10px 10px 300px");
        $(".hamburguer").css("left", "290px");
        $("#cssmenu").css("width", "290px")
    });
    $('#cssmenu li.active').addClass('open').children('ul').show();
    $('#cssmenu li.has-sub>a').on('click', function () {
        $(this).removeAttr('href');
        var element = $(this).parent('li');
        if (element.hasClass('open')) {
            element.removeClass('open');
            element.find('li').removeClass('open');
            element.find('ul').slideUp(200);
        }
        else {
            element.addClass('open');
            element.children('ul').slideDown(200);
            element.siblings('li').children('ul').slideUp(200);
            element.siblings('li').removeClass('open');
            element.siblings('li').find('li').removeClass('open');
            element.siblings('li').find('ul').slideUp(200);
        }
    });
    $('nav').height($(window).height() - 60);
    $(window).resize(function () {
        $('nav').height($(window).height() - 60);
    });
    $("html").niceScroll({
        cursorborderradius: 0,
        cursorwidth: "10px",
        cursorfixedheight: 150,
        cursorcolor: "#15992A",
        zindex: 9999,
        cursorborder: 0,
    }).resize();
});