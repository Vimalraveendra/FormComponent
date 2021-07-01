
window.loadScript = window.loadScript ||
    function () {
        loadUsers();
    }

window.setText = () => {
   console.log('hello')
   
    
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

    const mainListEl = document.querySelector(".list")

    //function addItem(item) {
    //    let LI = $(`<li>${item.name}</li>`)
    //   
    //    return LI
    //}

    function changeInputValue(e) {
        console.log(e.target)
        document.querySelector(".form-control").value = e.target.textContent;
        document.querySelector(".nazwisko").value = e.target.textContent;
    }

    function addItem(item) {
        let Li = document.createElement('li')
        let LiText = document.createTextNode(item.name)
        Li.appendChild(LiText)
        Li.addEventListener('click',changeInputValue)
            
        mainListEl.appendChild(Li)
    }

    //function addList() {
    //    //clearing the parent container before adding
    //    $('.list').html('');
    //    userData.forEach(item => {
    //        $('.list').append(addItem(item))
    //    })

    //}

  


    function addList() {
        mainListEl.innerHTML = "";
        userData.forEach(item => {
            addItem(item)
        })
    }


    addList();
  
    const contentWrapperEl = document.querySelector(".content-wrapper");
    mainListEl.addEventListener('click', function () {
        contentWrapperEl.classList.toggle('done')

    })

    //function showInputCredential(e) {
    //    document.querySelector(".form-control")value = e.target.textContent;
    //    document.querySelector(".nazwisko").value = e.target.textContent;   
   

    //}

    //const listEl = document.querySelectorAll('.list li');
    //console.log("osit", listEl)
    //listEl.forEach(list => {
    //    list.addEventListener('click', function () {
    //        console.log('list', list)
    //        document.querySelector(".form-control").list.textContent;
    //        document.querySelector(".nazwisko").value = list.textContent;
    //    })


        const rodzinaEl = document.querySelector('.rodzina')
        const showEl = document.querySelector(".show")
        showEl.addEventListener('click', function () {
            rodzinaEl.style.display = "block";
        })
    }


