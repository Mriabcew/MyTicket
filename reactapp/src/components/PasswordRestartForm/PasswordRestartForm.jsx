import React from 'react'

function PasswordRestartForm() {
    return (
        <form className="login" onSubmit={handleSubmit}>
          <label htmlFor="usernameOrEmail">Nazwa użytkownika lub adres e-mail</label>
          <input
                type="text"
                id="usernameOrEmail"
                name="usernameOrEmail"
                value={usernameOrEmail}
                onChange={(event) => setUsernameOrEmail(event.target.value)}
          />
          <label htmlFor="password">Hasło</label>
          <input
                type="password"
                className="form-control"
                id="password"
                name="password"
                value={password}
                onChange={(event) => setPassword(event.target.value)}
          />
           {errorMessage && <div className="alert alert-danger">{errorMessage}</div>}
          <button type="submit">Zaloguj się</button>
          <a href="AccountRestart">Nie pamietasz hasla?</a>
          <a href="Register">Nie masz konta?</a>
        </form>
    );
};
export default PasswordRestartForm