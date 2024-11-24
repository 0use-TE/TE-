window.initializeScrollEvent = (dotnetHelper) => {
    window.addEventListener('scroll', () => {
        if ((window.innerHeight + window.scrollY) >= document.body.offsetHeight) {
            // 当滚动到页面底部时调用 Blazor 方法
            dotnetHelper.invokeMethodAsync('OnScrollToBottom')
                .catch(error => console.error(error));
        }
    });
};
