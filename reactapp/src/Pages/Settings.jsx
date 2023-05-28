import React from 'react'
import ChangeEmailModal from '../components/Modals/ChangeEmailModal'
import ChangePasswordModal from '../components/Modals/ChangePasswordModal'
import DeleteAccountModal from '../components/Modals/DeleteAccountModal'
import ChangeUserInformations from '../components/Modals/ChangeUserInformations'
import ChangeProfileImg from '../components/Modals/ChangeProfileImg'
import Navbar from '../components/Navbar/Navbar'

import './SettingsStyles.css';
import ChangeBackgroundImg from '../components/Modals/ChangeBackgroundImg'

function Settings() {
  return (
    
    <div>
      <Navbar/>
      <div className='settings-menu'>
        <ChangeProfileImg/>
        <ChangeUserInformations/>
        <ChangeBackgroundImg/>
        <ChangeEmailModal/>
        <ChangePasswordModal/>
        <DeleteAccountModal/>
      </div>
    </div>
  )
}

export default Settings