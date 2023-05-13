$(document).ready(function () {
    function t() {
        function t() {
            var t;
            var w = jQuery(window).width();
            if (w > 895) {
                t = jQuery(window).width() / 2;
            }
            else if (w < 401) {
                t = jQuery(window).width();
            }
            else {
                t = jQuery(window).width() - 50;
            }
            jQuery(window).width() > t ? jQuery(".mainpage-mos").width(t) : jQuery(".mainpage-mos").width((jQuery(window).width()) + 0)
        } t(),
        jQuery(window).resize(t),
        $(".content-mos").masonry({ itemSelector: ".tile", columnWidth: 160, isAnimated: !0, isFitWidth: !0 }),
        $(".tile").not(".exclude").hover(function () { $(".tile").not(this).addClass("fade") }, function () { $(".tile").removeClass("fade") }),
        $(".live").liveTile({ pauseOnHover: !0 })
    }
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
   t();
});