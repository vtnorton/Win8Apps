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
});