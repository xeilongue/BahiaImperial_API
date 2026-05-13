const apiUrl = '/api/User';
const apiUrlAuth = '/api/Auth';

async function LoadUsers() {
    try {
        const response = await fetch(apiUrl);
        const User = await response.json();

        const tbody = document.getElementById('tablebody');
        tbody.innerHTML = '';

        User.forEach(user => {
            tbody.innerHTML +=
                `
                <tr>
                    <td>${user.cpf_Cnpj}</td>
                    <td>${user.password}</td>
                </tr>
            `
            console.log(user);
        });
    } catch (error) {
        alert("Erro ao buscar os dados.");
        console.error(error);
    }
}

async function LoginUser(event) {
    if (event) event.preventDefault();

    const user = {
        cpf_cnpj: document.getElementById("InputEmail").value,
        password: document.getElementById("InputPassword").value
    };

    try {
        const response = await fetch(apiUrlAuth + "/login", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(user)
        });

        if (response.ok) {
            alert("Login efetuado com sucesso!");
            window.location.href = "dashboard.html"

            const data = await response.json();
            const token = data.token;
            localStorage.setItem("jwtToken", token);
        } else {
            alert("Usuário ou senha incorretos")
        }
    } catch (erro) {
        console.error(erro);
    }
}

async function RegisterUser() {
    const token = document.getElementById('inputToken').value;

    if (!token) {
        alert("Acesso Negado: Cole o Token JWT primeiro!");
        return;
    }

    const newUser = {
        cpf_Cnpj: "1234567901",
        password: "123"
    };

    try {
        const resposta = await fetch(apiUrl, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            },
            body: JSON.stringify(newUser)
        });

        if (resposta.ok) {
            alert("Usuário cadastrado com sucesso!");
            LoadUsers();
        } else {
            alert("Erro 401: Token inválido ou expirado.");
        }
    } catch (erro) {
        console.error(erro);
    }
}