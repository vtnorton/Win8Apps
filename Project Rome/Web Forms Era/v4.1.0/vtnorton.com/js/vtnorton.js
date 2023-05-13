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

    $(".hamburger").click(function () { if ($(window).width() < 895) { $("nav").slideToggle("fast"); if ($(window).width() > 400) { $(".logo-written").toggle(); } } });
    var bb = "border-bottom", fPx = "5px solid #2572EB", nn = "none";
    $(".dpd-menu-dev").clickToggle(function () {
        $(".dpd-menu-dev ul").slideToggle(210);
        if ($(window).width() > 895) { $(".dpd-menu-dev").css(bb, fPx); }
    }, function () {
        $(".dpd-menu-dev ul").slideToggle(250);
        if ($(window).width() > 895) { $(".dpd-menu-dev").css(bb, nn); }
    }
    );
    $(".dpd-menu-suporte").clickToggle(function () {
        $(".dpd-menu-suporte ul").slideToggle(210);
        if ($(window).width() > 895) { $(".dpd-menu-suporte").css(bb, fPx); $(".fwm-suporte").toggle(); }
    }, function () {
        $(".dpd-menu-suporte ul").slideToggle(250);
        if ($(window).width() > 895) { $(".fwm-suporte").toggle(); $(".dpd-menu-suporte").css(bb, nn); }
    }
    );
    $(".dpd-menu-blog").clickToggle(function () {
        $(".dpd-menu-blog ul").slideToggle(210);
        if ($(window).width() > 895) { $(".fwm-blog").toggle(); $(".dpd-menu-blog").css(bb, fPx); }
    }, function () {
        $(".dpd-menu-blog ul").slideToggle(250);
        if ($(window).width() > 895) { $(".fwm-blog").toggle(); $(".dpd-menu-blog").css(bb, nn); }
    }
    );
    $(".dpd-menu-downloads").clickToggle(function () {
        $(".dpd-menu-downloads ul").slideToggle(210);
        if ($(window).width() > 895) { $(".fwm-downloads").toggle(); $(".dpd-menu-downloads").css(bb, fPx); }
    }, function () {
        $(".dpd-menu-downloads ul").slideToggle(250);
        if ($(window).width() > 895) { $(".dpd-menu-downloads").css(bb, nn); $(".fwm-downloads").toggle(); }
    }
    );
    $(".dpd-menu-contato").clickToggle(function () {
        $(".dpd-menu-contato ul").slideToggle(210);
        if ($(window).width() > 895) { $(".fwm-sobre").toggle(); $(".dpd-menu-contato").css(bb, fPx); }
    }, function () {
        $(".dpd-menu-contato ul").slideToggle(250);
        if ($(window).width() > 895) { $(".fwm-sobre").toggle(); $(".dpd-menu-contato").css(bb, nn); }
    }
    );
    $(".minimenu-acess").click(function () {
        $(".minimenu-panel-acess").slideToggle("fast");
        $(".minimenu-search-box").hide();
        $(".minimenu-panel-denunciar").hide();
        $(".minimenu-panel-acess-help").hide("fast");
    });
    $(".minimenu-search").click(function () {
        $(".minimenu-search-box").toggle(250);
        $(".minimenu-panel-acess").hide();
        $(".minimenu-panel-denunciar").hide();
        $(".minimenu-panel-acess-help").hide();
    });
    $(".minimenu-denunciar").click(function () {
        $(".minimenu-panel-denunciar").slideToggle("fast");
        $(".minimenu-search-box").hide();
        $(".minimenu-panel-acess").hide();
        $(".minimenu-panel-acess-help").hide();
    });
    $(".minimenu-acess-fonte").click(function () {
        $(".minimenu-acess-fonte-lista").slideToggle("fast");
    });
    var pFontSize = 14, pH1 = 30, pH2 = 27, pH3 = 25, pH4 = 20, pH5 = 16, pLineHeight = 19;
    var pFontFamily = "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", pTextAlign = "left";
    $(".minimenu-acess-fonte-maior").click(function () {
        if (pFontSize < 42) {
            if (pFontSize <= 19) {
                $("p").css("font-size", pFontSize++ + "px");
                $("article h1").css("font-size", pH1++ + "px");
            }
            if ((pFontSize < 42) || (pFontSize > 20)) {
                $("p").css({ "font-size": pFontSize++ + "px", "line-height": pLineHeight++ + "px" });
                $("article h1").css("font-size", pH1++ + "px");
            }
        }
    });
    $(".minimenu-acess-fonte-menor").click(function () {
        if (pFontSize >= 10) {
            $("p").css("font-size", pFontSize-- + "px");
            $("article h1").css("font-size", pH1-- + "px");
        }
        if ((pFontSize < 42) || (pFontSize > 20)) {
            $("p").css("line-height", pLineHeight + "px");
        }
    });
    $("#arial").click(function () {
        $("article").css("font-family", "Arial");
        $("p").css("font-family", "Arial");
    });
    $("#georgia").click(function () {
        $("article").css("font-family", "Georgia, 'Times New Roman', Times, serif");
        $("p").css("font-family", "Georgia, 'Times New Roman', Times, serif");
    });
    $("#segoe").click(function () {
        $("article").css("font-family", "'Segoe UI'");
        $("p").css("font-family", "'Segoe UI'");
    });
    $("#times").click(function () {
        $("article").css("font-family", "'Times New Roman'");
        $("p").css("font-family", "'Times New Roman'");
    });
    $(".maiar").click(function () {
        $("p").css("text-align", "right");
    });
    $(".maiac").click(function () {
        $("p").css("text-align", "justify");
    });
    $(".maiae").click(function () {
        $("p").css("text-align", "left");
    });
    $(".mairc").click(function () {
        $("article").css({ "font-size": "14px", "font-family": "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", "line-height": "19px", "text-align": "left" });
        $("p").css({ "font-size": "14px", "font-family": "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", "line-height": "19px", "text-align": "left" });
        $("article h1").css("font-size", "30px");
        $("article h2").css("font-size", "27px");
        $("article h3").css("font-size", "25px");
        $("article h4").css("font-size", "20px");
        $("article h5").css("font-size", "16px");
        pFontSize = 14, pH1 = 30, pH2 = 27, pH3 = 25, pH4 = 20, pH5 = 16, pLineHeight = 19;
        pFontFamily = "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", pTextAlign = "left";
    });

    $(window).scroll(function () {
        var window_scrolltop = $(this).scrollTop();
        $('.parallax').each(function () {
            var obj = $(this);
            if (window_scrolltop >= obj.position().top - obj.height()
				&& window_scrolltop <= obj.position().top + obj.height()) {
                var divisor = typeof obj.attr('data-divisor') == 'undefined' ? 4 : obj.attr('data-divisor');
                if (obj.is(':first-child')) {
                    var bg_pos = (window_scrolltop - obj.position().top) / divisor;
                } else {
                    var bg_pos = (window_scrolltop - obj.position().top + (obj.height() - 100)) / divisor;
                }
                obj.css({
                    'background-position': '50% -' + bg_pos + 'px'
                });
                obj.children('.text').css({
                    'bottom': (window_scrolltop - obj.position().top + 100) + 'px'
                });
            }
        });
    });
    (function (window, $) {
        $(function () {
            $('.ripple').on('click', function (event) {
                event.preventDefault();
                var $div = $('<div/>'), btnOffset = $(this).offset(), xPos = event.pageX - btnOffset.left, yPos = event.pageY - btnOffset.top;
                $div.addClass('ripple-effect');
                var $ripple = $(".ripple-effect");
                $ripple.css("height", $(this).height());
                $ripple.css("width", $(this).height());
                $div.css({ top: yPos - ($ripple.height() / 2), left: xPos - ($ripple.width() / 2), background: $(this).data("ripple-color") }).appendTo($(this));
                window.setTimeout(function () { $div.remove(); }, 2000);
            });
        });

    })(window, jQuery);

    $(this).delay(1500).queue(function () { $(".one").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".two").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".three").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".four").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".five").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".six").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".seven").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".eight").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".nine").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".ten").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".eleven").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".twelve").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".thirteen").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".fourteen").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".fifteen").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".sixteen").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".seventeen").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".eighteen").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".nineteen").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".twenty").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".twentyone").addClass("selected"); $(this).dequeue(); })
    .delay(500).queue(function () { $(".twentytwo").addClass("selected"); $(this).dequeue(); });
});