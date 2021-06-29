
window.loadScript = window.loadScript ||
    function () {
        loadUsers();
    }

window.setText = () => {
    let text = document.querySelector(".form-control").value = "Boss";
    let text12 = document.querySelector(".nazwisko").value = "Boss";
    let text1 = document.querySelector(".nazwisko1").value = "Boss1";
    let text2 = document.querySelector(".nazwisko2").value = "Boss2";

    


}

function loadUsers() {
    const userData = [
        {
            id: 1000,
            name: "John"
        }, {
            id: 10002,
            name: "Boss"
        },
        , {
            id: 10003,
            name: "Mann"
        },
        , {
            id: 10004,
            name: "Denver"
        },
        , {
            id: 10005,
            name: "Jackson"
        },
    ]

  

    function addItem(item) {
        let LI = $(`<li>${item.name}</li>`)
        return LI
    }

    function addList() {
        //clearing the parent container before adding
        $('.list').html('');
        userData.forEach(item => {
            $('.list').append(addItem(item))
        })

    }



    addList();
    const mainListEl = document.querySelector(".list")
    const contentWrapperEl = document.querySelector(".content-wrapper");
    mainListEl.addEventListener('click', function () {
        contentWrapperEl.classList.toggle('done')
        document.querySelector(".nazwisko").value = "Boss";
    })
    //const listEl = document.querySelectorAll('.list li');
    
    //listEl.forEach(list => {
    //    list.addEventListener('click', function () {
    //        contentWrapperEl.classList.toggle('done')
    //        document.querySelector(".nazwisko").value = list.textContent;
    //    })
    //})
}