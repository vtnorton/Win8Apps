$(document).ready(function () {
    function t() {
        function t() {
            var t = jQuery(window).width();

            if (jQuery(window).width() < 895) {
                jQuery(window).width() > t ? jQuery("#mainpage-mos").width(t) : jQuery("#mainpage-mos").width((jQuery(window).width()) + 0)
            } else {
                jQuery(window).width() * 0.7 > t ? jQuery("#mainpage-mos").width(t) : jQuery("#mainpage-mos").width((jQuery(window).width() * 0.7) - 100)
            }
            
        } t(),
        jQuery(window).resize(t),
        $("#content-mos").masonry({ itemSelector: ".tile", columnWidth: 160, isAnimated: !0, isFitWidth: !0 }),
        $(".tile").not(".exclude").hover(function () { $(".tile").not(this).addClass("fade") }, function () { $(".tile").removeClass("fade") }),
        $(".live").liveTile({ pauseOnHover: !0 })
    }
    function closeAll() {
        $("#tile-1").hide(),
        $("#tile-3").hide(),
        $("#tile-4").hide(),
        $("#tile-5").hide(),
        $("#tile-6").hide(),
        $("#tile-7").hide(),
        $("#tile-8").hide(),
        $("#tile-9").hide(),
        $("#tile-25").hide(),
        $("#tile-26").hide(),
        $("#tile-27").hide(),
        $("#tile-100").hide()
    };
    $(".tile-1").click(function () { $("#tile-1").css("display", "block") });
    $(".tile-3").click(function () { $("#tile-3").css("display", "block") });
    $(".tile-4").click(function () { $("#tile-4").css("display", "block") });
    $(".tile-5").click(function () { $("#tile-5").css("display", "block") });
    $(".tile-6").click(function () { $("#tile-6").css("display", "block") });
    $(".tile-7").click(function () { $("#tile-7").css("display", "block") });
    $(".tile-8").click(function () { $("#tile-8").css("display", "block") });
    $(".tile-9").click(function () { $("#tile-9").css("display", "block") });
    $(".tile-25").click(function () { $("#tile-25").css("display", "block") });
    $(".tile-26").click(function () { $("#tile-26").css("display", "block") });
    $(".tile-27").click(function () { $("#tile-27").css("display", "block") });
    $("#menu-Palestras").click(function () { $("#tile-100").css("display", "block") });
    $("#menu-CloseAll").click(function () { closeAll() });
    $(".close").click(function () { closeAll() });

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

    $(".social-menu").clickToggle(function () { $("footer ul").css("display", "block"), $(".menus").css("top", "10px")},
        function () { $("footer ul").css("display", "none"), $(".menus").css("top", "33px"), $("nav ul").css("display", "none") });
    $(".main-menu").clickToggle(function () { $("nav ul").css("display", "block"), $(".menus").css("top", "15px") },
        function () { $("nav ul").css("display", "none"), $(".menus").css("top", "33px"), $("footer ul").css("display", "none") });

    $('#posts-tile7').FeedEk({ FeedUrl: 'http://blog.vtnorton.com/feed/', MaxCount: 5, ShowDesc: true, ShowPubDate: false, DescCharacterLimit: 240 });
    $('#posts-tile9').FeedEk({ FeedUrl: 'http://garotodeprograma.vtnorton.com/feed/', MaxCount: 5, ShowDesc: true, ShowPubDate: false, DescCharacterLimit: 240 });


    t();
});