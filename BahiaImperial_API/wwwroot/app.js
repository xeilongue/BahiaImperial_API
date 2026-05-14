const apiUrl = '/api/User';
const apiUrlAuth = '/api/Auth';

function Logout() {
    localStorage.removeItem('jwtToken');
    window.location.href = 'index.html';
}

async function LoadUsers() {
    const token = localStorage.getItem('jwtToken');

    try {
        const response = await fetch(apiUrl, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${token}`
            }
        });

        if (response.status === 401) {
            alert("Sessão expirada ou acesso negado. Faça login novamente.");
            localStorage.removeItem('jwtToken');
            window.location.href = "index.html";
            return;
        }

        if (!response.ok) {
            throw new Error("Erro ao carregar os dados do servidor.");
        }

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
            `;
        });

    } catch (error) {
        alert("Erro ao buscar os dados.");
        console.error(error);
    }
}

async function LoginUser(event) {
    if (event) event.preventDefault();

    const user = {
        cpf_Cnpj: document.getElementById("InputEmail").value,
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
            window.location.href = "dashboard.html";

            const data = await response.json();
            const token = data.token;
            localStorage.setItem("jwtToken", token);
        } else {
            alert("Usuário ou senha incorretos!");
        }
    } catch (error) {
        console.error(error);
    }
}

async function RegisterUser(event) {
    if (event) event.preventDefault();
    const newUser = {
        cpf_Cnpj: document.getElementById("InputEmailRegister").value,
        password: document.getElementById("InputPasswordRegister").value
    };

    try {
        const response = await fetch(apiUrl, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(newUser)
        });

        const data = await response.json();
        if (response.ok) {
            alert("Usuário cadastrado com sucesso. Efetue o login!");
            window.location.href = "index.html";
            return;
        } else {
            alert(data.message);
        }
    } catch (error) {
        alert("Erro de conexão com o servidor.");
        console.error(error);
    }

}