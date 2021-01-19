using System;

namespace DataRecorder.Models
{
    /// <summary>
    /// HTTPStatus����܂邱��
    /// �Q�[�����̃X�e�[�^�X���Ǘ�����N���X�ł��B�Q�[������1�̃C���X�^���X�����쐬����܂���B
    /// </summary>
    public class GameStatus
    {
        // �v���p�e�B
        /// <summary>
        /// StatusObject[Game] mode : �p�[�e�B���[�h
        /// </summary>
        public bool partyMode { get; set; } = false;

        /// <summary>
        /// StatusObject[Game] mode : �Q�[�����[�h
        /// </summary>
        public string mode { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȗ�
        /// </summary>
        public string songName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȃ̃T�u�^�C�g��
        /// </summary>
        public string songSubName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȃ̍��
        /// </summary>
        public string songAuthorName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̍��
        /// </summary>
        public string levelAuthorName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ����ID(SHA-1)
        /// </summary>
        public string songHash { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ����ID(Raw)
        /// </summary>
        public string levelId { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȃ�BPM
        /// </summary>
        public float songBPM { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ�NJS
        /// </summary>
        public float noteJumpSpeed { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʊJ�n�I�t�Z�b�g�l(�擾�o���Ă��Ȃ��H)
        /// </summary>
        public long songTimeOffset { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̒���[ms]
        /// </summary>
        public long length { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʃv���C�J�n���̎��ԁB�ĊJ���ɍX�V�B(UNIX time[ms])
        /// </summary>
        public long start { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] �ꎞ��~���̎���(UNIX time[ms])
        /// </summary>
        public long paused { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̓�Փx
        /// </summary>
        public string difficulty { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̃m�[�c��
        /// </summary>
        public int notesCount { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̔��e��
        /// </summary>
        public int bombsCount { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̕ǂ̐�
        /// </summary>
        public int obstaclesCount { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���݂�Mod�ł̍ő�X�R�A
        /// </summary>
        public int maxScore { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���݂�Mod�ł̍ő僉���N
        /// </summary>
        public string maxRank { get; set; } = "E";

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̗v����
        /// </summary>
        public string environmentName { get; set; } = null;

        /// <summary>
        /// StatusObject[Performance] ���݂̃X�R�A
        /// </summary>
        public int score { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃m�[�c���ŒB���\�ȍő�X�R�A
        /// </summary>
        public int currentMaxScore { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃����N
        /// </summary>
        public string rank { get; set; } = "E";

        /// <summary>
        /// StatusObject[Performance] ���ݏ��������m�[�c��
        /// </summary>
        public int passedNotes { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݃q�b�g�����m�[�c��
        /// </summary>
        public int hitNotes { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݃~�X�����m�[�c��
        /// </summary>
        public int missedNotes { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] �i���擾�j
        /// </summary>
        public int lastNoteScore { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���ݏ����������e��
        /// </summary>
        public int passedBombs { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݃q�b�g�������e��
        /// </summary>
        public int hitBombs { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃R���{��
        /// </summary>
        public int combo { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̍ő�R���{��
        /// </summary>
        public int maxCombo { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃R���{�搔
        /// </summary>
        public int multiplier { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃R���{�搔�̐i�s�
        /// </summary>
        public float multiplierProgress { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃o�b�e���G�l���M�[�c��
        /// </summary>
        public int batteryEnergy { get; set; } = 1;

        /// <summary>
        /// StatusObject[Performance] ���݂̃G�l���M�[�c��
        /// </summary>
        public float energy { get; set; } = 0;

        /// <summary>
        /// StatusObject[Mods] Mod�搔
        /// </summary>
        public float modifierMultiplier { get; set; } = 1f;

        /// <summary>
        /// StatusObject[Mods] �ǂ̗L��
        /// </summary>
        public string modObstacles { get; set; } = "All";

        /// <summary>
        /// StatusObject[Mods] �m�[�~�X
        /// </summary>
        public bool modInstaFail { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �m�[�t�@�E��
        /// </summary>
        public bool modNoFail { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �o�b�e���G�l���M�[
        /// </summary>
        public bool modBatteryEnergy { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �ő�o�b�e���c��(DB���L�^)
        /// </summary>
        public int batteryLives { get; set; } = 1;

        /// <summary>
        /// StatusObject[Mods] ��������
        /// </summary>
        public bool modDisappearingArrows { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] ���e����
        /// </summary>
        public bool modNoBombs { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �Ȃ̑��x
        /// </summary>
        public string modSongSpeed { get; set; } = "Normal";

        /// <summary>
        /// StatusObject[Mods] �Ȃ̑��x��Mod�搔
        /// </summary>
        public float songSpeedMultiplier { get; set; } = 1f;

        /// <summary>
        /// StatusObject[Mods] ��󖳂�
        /// </summary>
        public bool modNoArrows { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �S�[�X�g�m�[�c
        /// </summary>
        public bool modGhostNotes { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �Z�C�o�[�N���b�V���Ŏ��s�H�iHidden)
        /// </summary>
        public bool modFailOnSaberClash { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �����Ȋp�x(Hidden)
        /// </summary>
        public bool modStrictAngles { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] Does something (Hidden)
        /// </summary>
        public bool modFastNotes { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] �ÓI���C�g
        /// </summary>
        public bool staticLights { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] ������
        /// </summary>
        public bool leftHanded { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] �v���C���[�̍���
        /// </summary>
        public float playerHeight { get; set; } = 1.7f;

        /// <summary>
        /// StatusObject[Player settings] �m�[�c�J�b�g����
        /// </summary>
        public float sfxVolume { get; set; } = 0.7f;

        /// <summary>
        /// StatusObject[Player settings] �m�[�c�J�b�g���̔j�ЗL��
        /// </summary>
        public bool reduceDebris { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] �e�L�X�g��HUD����
        /// </summary>
        public bool noHUD { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] Advanced HUD
        /// </summary>
        public bool advancedHUD { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] ���s���Ɏ������X�^�[�g
        /// </summary>
        public bool autoRestart { get; set; } = false;

        // �萔
        /// <summary>
        /// noteScore�z�񏉊����T�C�Y (�K�v�Ȕz��T�C�Y�̓m�[�c���{���e��)
        /// </summary>
        private const int initNoteScoreSize = 3000;

        /// <summary>
        /// noteScore�z��ǉ��T�C�Y
        /// </summary>
        private const int addNoteScoreSize = 500;

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z�񏉊����T�C�Y
        /// </summary>
        private const int initEnergyDataSize = 1000;

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��ǉ��T�C�Y
        /// </summary>
        private const int addEnergyDataSize = 500;

        // �����o�ϐ�
        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��
        /// </summary>
        private NoteDataEntity[] noteScores = new NoteDataEntity[initNoteScoreSize];

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��
        /// </summary>
        private EnergyDataEntity[] energyDatas = new EnergyDataEntity[initEnergyDataSize];

        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��̏������ς݃T�C�Y
        /// </summary>
        private int initNoteSize = 0;

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��̏������ς݃T�C�Y
        /// </summary>
        private int initEnergySize = 0;

        // ���\�b�h

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GameStatus()
        {
            NoteInit();
            EnergyInit();
        }

        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��S�̏�����
        /// </summary>
        private void NoteInit()
        {
            while (initNoteSize < noteScores.Length) {
                noteScores[initNoteSize] = new NoteDataEntity();
                initNoteSize++;
            }
        }

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��S�̏�����
        /// </summary>
        private void EnergyInit()
        {
            while (initEnergySize < energyDatas.Length) {
                energyDatas[initEnergySize] = new EnergyDataEntity();
                initEnergySize++;
            }
        }

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��̃��T�C�Y
        /// </summary>
        public void EnergyResize()
        {
            Array.Resize(ref energyDatas, initEnergySize + addEnergyDataSize);
        }

        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��̃��T�C�Y
        /// </summary>
        public void NoteResize(int size)
        {
            Array.Resize(ref noteScores, size + addNoteScoreSize);
        }



        public void ResetMapInfo()
        {
            this.songName = null;
            this.songSubName = null;
            this.songAuthorName = null;
            this.levelAuthorName = null;
            this.songHash = null;
            this.levelId = null;
            this.songBPM = 0f;
            this.noteJumpSpeed = 0f;
            this.songTimeOffset = 0;
            this.length = 0;
            this.start = 0;
            this.paused = 0;
            this.difficulty = null;
            this.notesCount = 0;
            this.obstaclesCount = 0;
            this.maxScore = 0;
            this.maxRank = "E";
            this.environmentName = null;
        }

        public void ResetPerformance()
        {
            this.score = 0;
            this.currentMaxScore = 0;
            this.rank = "E";
            this.passedNotes = 0;
            this.hitNotes = 0;
            this.missedNotes = 0;
            this.lastNoteScore = 0;
            this.passedBombs = 0;
            this.hitBombs = 0;
            this.combo = 0;
            this.maxCombo = 0;
            this.multiplier = 0;
            this.multiplierProgress = 0;
            this.batteryEnergy = 1;
            this.energy = 0;
        }

        public void ResetNoteCut()
        {
            this.noteID = -1;
            this.noteType = null;
            this.noteCutDirection = null;
            this.speedOK = false;
            this.directionOK = false;
            this.saberTypeOK = false;
            this.wasCutTooSoon = false;
            this.initialScore = -1;
            this.finalScore = -1;
            this.cutDistanceScore = -1;
            this.cutMultiplier = 0;
            this.saberSpeed = 0;
            this.saberDirX = 0;
            this.saberDirY = 0;
            this.saberDirZ = 0;
            this.saberType = null;
            this.swingRating = 0;
            this.timeDeviation = 0;
            this.cutDirectionDeviation = 0;
            this.cutPointX = 0;
            this.cutPointY = 0;
            this.cutPointZ = 0;
            this.cutNormalX = 0;
            this.cutNormalY = 0;
            this.cutNormalZ = 0;
            this.cutDistanceToCenter = 0;
        }
    }
}
