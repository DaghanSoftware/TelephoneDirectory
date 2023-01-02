import React from 'react'

 const Footer = () => {
  return (
    <footer className="tm-bg-dark-blue">
    <div className="container">
      <div className="row">
        <p className="col-sm-12 text-center tm-font-light tm-color-white p-4 tm-margin-b-0">
          Copyright &copy; <span className="tm-current-year">2023</span>{" "}
          SolarTeam - Design:{" "}
          <a
            rel="nofollow"
            href="https://www.SolarTeam.com"
            className="tm-color-primary tm-font-normal"
            target="_parent"
          >
            SolarTeam
          </a>
        </p>
      </div>
    </div>
  </footer>
  )
}
export default Footer;