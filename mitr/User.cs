using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace mitr
{
    internal class User
    {
        /// <summary>
        /// фоновый поток
        /// </summary>
        BackgroundWorker worker = new BackgroundWorker() { WorkerReportsProgress = true };//поддерживает сообщения о прогрессе

        public User()
        {
            //конструктор класса - подвязывает события изменения прогресса и запускает работу потока
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;
        }

        /// <summary>
        /// работа потока - запрос на изменение счёта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
             worker.ReportProgress(0, (long)e.Argument);
        }

        /// <summary>
        /// положить или снять деньги (зависит от того отрицательное число или положительное)
        /// </summary>
        /// <param name="money"></param>
        public void TakeMoney(long money)
        {
            worker.RunWorkerAsync(money);
        }

        /// <summary>
        /// меняем состояние счёта из нашего потока
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Bank.ChangeCount((long)e.UserState);
        }
    }
}
